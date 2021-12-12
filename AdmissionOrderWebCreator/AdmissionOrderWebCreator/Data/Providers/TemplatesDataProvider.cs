using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using AdmissionOrderWebCreator.Models.Config;
using System.IO;
using Word = Microsoft.Office.Interop.Word;

namespace AdmissionOrderWebCreator.Data.Providers
{
    public class TemplatesDataProvider
    {
        protected readonly TemplatePath[] Templates;
        //protected readonly Word.Application Application = new() { Visible = true };
        public TemplatesDataProvider(IConfiguration configuration)
        {
            Templates = configuration.GetValue<TemplatePath[]>("templates");
        }

        public TemplatePath[] GetAllTemplates() => Templates;

        /// <summary> Always returns a template. If it isn't found, throws an exception </summary>
        public string GetTemplatePath(string name)
        {
            var result = Templates.FirstOrDefault(t => t.Name == name);
            if (result is null) throw new Exception($"Template with name {name} not found");
            return result.Path;
        }

        public Word.Document GetTemplateDocument(string name)
        {
            var path = GetTemplatePath(name);
            if (!File.Exists(path)) throw new Exception($"Template file with name {name} and path {path} not found");

            // https://stackoverflow.com/questions/19252252/c-sharp-word-interop-find-and-replace-everything
            //Application.Selection.Find.Execute(
            //    FindText: true,
            //    MatchCase: true,
            //    MatchWholeWord: true,
            //    MatchWildcards: true,
            //    MatchSoundsLike: true,
            //    MatchAllWordForms: true,
            //    Forward: true,
            //    Wrap: true,
            //    Format: true,
            //    ReplaceWith: "",
            //    Replace: "",
            //    MatchKashida: true,
            //    MatchDiacritics: true,
            //    MatchAlefHamza: true,
            //    MatchControl: true);


        }
    }
}
