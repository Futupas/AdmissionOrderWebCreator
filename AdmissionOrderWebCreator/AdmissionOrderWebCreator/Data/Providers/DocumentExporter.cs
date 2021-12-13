using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionOrderWebCreator.Data.Providers
{
    public class DocumentExporter
    {
        protected readonly ILogger Logger;
        public DocumentExporter(
            IConfiguration configuration,
            ILoggerFactory loggerFactory)
        {
            Logger = loggerFactory.CreateLogger<DocumentExporter>();

        }


    }
}
