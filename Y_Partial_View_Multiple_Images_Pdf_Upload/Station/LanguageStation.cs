using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Y_Partial_View_Multiple_Images_Pdf_Upload.Data;
using Y_Partial_View_Multiple_Images_Pdf_Upload.Models;

namespace Y_Partial_View_Multiple_Images_Pdf_Upload.Station
{
    public class LanguageStation
    {
        private readonly DataContext _context = null;
        public LanguageStation(DataContext context)
        {
            _context = context;
        }

        public async Task<List<LanguageModel>> GetLanguage()
        {
            return await _context.Languages.Select(x=> new LanguageModel()
            {
                Id=x.Id,
                Name=x.Name,
                Description=x.Description

            }).ToListAsync();
        }
    }
}
