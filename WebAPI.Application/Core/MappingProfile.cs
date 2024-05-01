using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Calificaciones.GetCalificaciones;
using WebAPI.Application.Cursos.GetCurso;
using WebAPI.Application.Fotos.GetFoto;
using WebAPI.Application.Instructores.GetInstructores;
using WebAPI.Application.Precios.GetPrecios;
using WebAPI.Domain;

namespace WebAPI.Application.Core
{
    public class MappingProfile : Profile
    {

        public MappingProfile() 
        {
            CreateMap<Curso,CursoResponse>();
            CreateMap<Foto,FotoResponse>();
            CreateMap<Precio,PrecioResponse>();
            CreateMap<Instructor, InstructorResponse>()
                .ForMember(dest => dest.Apellido, src => src.MapFrom(doc => doc.Apellidos));
            CreateMap<Calificacion, CalificacionResponse>()
                .ForMember(dest => dest.NombreCurso, src => src.MapFrom(doc => doc.Curso!.Titulo));

        }

    }
}
