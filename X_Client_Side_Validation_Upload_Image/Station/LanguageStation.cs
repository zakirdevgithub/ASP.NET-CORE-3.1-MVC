﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X_Client_Side_Validation_Upload_Image.Data;
using X_Client_Side_Validation_Upload_Image.Models;

namespace X_Client_Side_Validation_Upload_Image.Station
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