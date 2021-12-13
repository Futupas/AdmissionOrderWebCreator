using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using AdmissionOrderWebCreator.Models.Config;
using System.IO;
//using Aspose.Words;
using Microsoft.Extensions.Logging;

namespace AdmissionOrderWebCreator.Data.Providers
{
    public class TemplatesDataProvider
    {
        protected readonly TemplatePath[] Templates;
        protected readonly ILogger Logger;
        public TemplatesDataProvider(
            IConfiguration configuration,
            ILoggerFactory loggerFactory)
        {
            Templates = configuration.GetSection("templates").Get<TemplatePath[]>() ?? throw new Exception("Coudn't find templates section in configuration");
            Logger = loggerFactory.CreateLogger<TemplatesDataProvider>();
        }

        public TemplatePath[] GetAllTemplates() => Templates;

        /// <summary> Always returns a template. If it isn't found, throws an exception </summary>
        public string GetTemplatePath(string name)
        {
            var result = Templates.FirstOrDefault(t => t.Name == name);
            if (result is null) throw new Exception($"Template with name {name} not found");
            return result.Path;
        }

        //public Document GetTemplateDocument(string name)
        //{
        //    var path = GetTemplatePath(name);
        //    if (!File.Exists(path)) throw new Exception($"Template file with name {name} and path {path} not found");

        //    var doc = new Document(path);

        //    return doc;
        //}
    }
}
