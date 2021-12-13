using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Aspose.Words;
using Microsoft.Extensions.Logging;
using System.IO;
using Microsoft.Extensions.Configuration;
//using Aspose.Words.Replacing;

namespace AdmissionOrderWebCreator.Data
{
    public class TemplateReplacer
    {
        protected readonly ILogger Logger;
        public TemplateReplacer(
            IConfiguration configuration,
            ILoggerFactory loggerFactory)
        {
            Logger = loggerFactory.CreateLogger<TemplateReplacer>();
        }

        //public void FindReplaceAndSave(Document source, string pattern, string replacement, Stream stream, bool saveToPdf = false)
        //{
        //    source.Range.Replace(pattern, replacement, new FindReplaceOptions(FindReplaceDirection.Forward));
        //    var saveFormat = saveToPdf ? SaveFormat.Pdf : SaveFormat.Docx;

        //    source.Save(stream, saveFormat);
        //}
    }
}
