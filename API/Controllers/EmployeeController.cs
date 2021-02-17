using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class EmployeeController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly ITokenService _tokenService;
        public EmployeeController(DataContext context, ITokenService tokenService)
        {
            _tokenService = tokenService;
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<AppEmployee>>> GetEmployees()
        {
            return await _context.Tbl_Employee.ToListAsync();
        }


        [HttpGet("/Api/GetVwEmployees")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<view_employee>>> GetVwEmployees()
        {
            return await _context.Vw_Employee.ToListAsync();
        }

        [HttpGet("/Api/GetTbl_Country")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Tbl_Country>>> GetTbl_Country()
        {
            return await _context.Tbl_Country.ToListAsync();
        }

      


        [Authorize]
        [HttpGet("/Api/GetVwEmployeeAuthorize")]
        public async Task<ActionResult<IEnumerable<view_employee>>> GetVwEmployeeAuthorize()
        {
            return await _context.Vw_Employee.ToListAsync();
        }
    }
}
