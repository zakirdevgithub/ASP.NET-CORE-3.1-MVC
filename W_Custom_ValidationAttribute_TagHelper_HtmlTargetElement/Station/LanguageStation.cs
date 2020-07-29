using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using W_Custom_ValidationAttribute_TagHelper_HtmlTargetElement.Data;
using W_Custom_ValidationAttribute_TagHelper_HtmlTargetElement.Models;

namespace W_Custom_ValidationAttribute_TagHelper_HtmlTargetElement.Station
{
    public class LanguageStation
    {
        private readonly DataContext _context = null;

        public LanguageStation(DataContext context)
        {
            _context = context;
        }

        public List<LanguageModel> GetLanguage()
        {
            return _context.Languages.Select(x => new LanguageModel()
            {
                Id=x.Id,
                Name=x.Name
            }).ToList();
        }
    }
}
