using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.interfaces;
using WebAPI.Domain;

namespace WebAPI.Infrastructure.Reports
{
    public class ReportService<T> : IReportService<T> where T : ClaseBase
    {
        public Task<MemoryStream> GetCsvReport(List<T> records)
        {
            using var memoryStream = new MemoryStream();
            using var textWritter = new StreamWriter(memoryStream);
            using var csvWritter = new CsvWriter(textWritter, CultureInfo.InvariantCulture);

            csvWritter.WriteRecords(records);
            textWritter.Flush();//limpiar el textwriter
            memoryStream.Seek(0,SeekOrigin.Begin);//resetear la posicion

            return Task.FromResult(memoryStream);
        }
    }
}
