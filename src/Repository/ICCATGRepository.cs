﻿using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Triton.Core;
using Triton.FleetManagement.WebApi.Interface;
using Triton.Service.Model.TFFDAT.Tables;

namespace Triton.FleetManagement.WebApi.Repository
{
    public class ICCATGRepository : IICCATG
    {
        private readonly IConfiguration _config;

        public ICCATGRepository(IConfiguration configuration)
        {
            _config = configuration;
        }

        public async Task<List<ICCATG>> GetAsync()
        {
            const string sql = "SELECT * FROM ICCATG WHERE INACTIVE = 0 ORDER BY CATEGORY";
            await using var connection = DBConnection.GetOpenConnection(_config.GetConnectionString(StringHelpers.Database.TFFDAT));
            return connection.Query<ICCATG>(sql).ToList();
        }
    }
}
