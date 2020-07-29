using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using V_Dropdown_With_Database.Data;
using V_Dropdown_With_Database.Models;

namespace V_Dropdown_With_Database.Station
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
                Name=x.Name,
                Description= x.Description
            }).ToList();
        }
    }
}
