using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Core;
using WebAPI.Application.Cursos.GetCurso;
using WebAPI.Domain;
using WebAPI.Persistence;

namespace WebAPI.Application.Cursos.GetCursos
{
    public class GetCursosQuery
    {

        public record GetCursosQueryRequest
            : IRequest<Result<PagedList<CursoResponse>>>
        {

            public GetCursosRequest? CursosRequest { get; set; }
        }

        internal class GetCursosQueryHandler
            : IRequestHandler<GetCursosQueryRequest, Result<PagedList<CursoResponse>>>
        {
            private readonly ApplicationDbContext context;
            private readonly IMapper mapper;

            public GetCursosQueryHandler(ApplicationDbContext context,IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }
            public async Task<Result<PagedList<CursoResponse>>> Handle(
                  GetCursosQueryRequest request, 
                  CancellationToken cancellationToken)
            {

                IQueryable<Curso> queryable = context.Cursos!
                                                .Include(x => x.Instructores)
                                                .Include(x => x.Calificaciones)
                                                .Include(x => x.Precios);

                var predicate = ExpressionBuilder.New<Curso>();
                if (!string.IsNullOrEmpty(request.CursosRequest!.Titulo))
                {
                    predicate =
                     predicate.And(y => y.Titulo!.ToLower()
                    .Contains(request.CursosRequest.Titulo.ToLower()));
                }
                if (!string.IsNullOrEmpty(request.CursosRequest!.Descripcion))
                {
                    predicate =
                     predicate.And(y => y.Descripcion!.ToLower()
                    .Contains(request.CursosRequest.Descripcion.ToLower()));
                }

                if(!string.IsNullOrEmpty(request.CursosRequest.OrderBy))
                {
                    Expression<Func<Curso, object>>? orderBySelector =
                        request.CursosRequest.OrderBy!.ToLower() switch
                        {
                            "titulo" => curso => curso.Titulo!,
                            "descripcion" => curso => curso.Descripcion!,
                            _ => curso => curso.Titulo!
                        };

                    bool orderBy = request.CursosRequest.OrderAsc.HasValue ?
                            request.CursosRequest.OrderAsc.Value
                            : true;

                    queryable = orderBy
                                  ? queryable.OrderBy(orderBySelector)
                                  : queryable.OrderByDescending(orderBySelector);
                }

                queryable = queryable.Where(predicate);

                var cursosQuery = queryable
                    .ProjectTo<CursoResponse>(mapper.ConfigurationProvider)
                    .AsQueryable();

                var pagination = await PagedList<CursoResponse>.CreateAsync(
                        cursosQuery,
                        request.CursosRequest.PageNumber,
                        request.CursosRequest.PageSize
                    );

                return Result<PagedList<CursoResponse>>.Success(pagination);
            }
        }
    }
}
