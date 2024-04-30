using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Domain;

namespace WebAPI.Application.interfaces
{
    public interface IReportService<T> where T : ClaseBase
    {
        Task<MemoryStream> GetCsvReport(List <T> records);
    }
}
