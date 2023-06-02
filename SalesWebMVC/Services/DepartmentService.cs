using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCContext _context;

        public DepartmentService(SalesWebMVCContext context)
        {
            _context = context;
        }
        //async function
        public async Task<List<Departments>> FindAllAsync()
        {
            return await _context.Departments.OrderBy(x => x.Name).ToListAsync();
        }

      
    }
}
