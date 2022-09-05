using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pagination_Api.DB_Conn;
using pagination_Api.DB_Model;
using pagination_Api.Emp_repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pagination_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly DB_Contexts _Db;

        public EmpController(DB_Contexts db)
        {
            _Db = db;
        }

        [HttpGet]
        [Route("allEmp")]
        public ActionResult<List<EmpInfo>> getAllEmp()
        {
            return _Db.Empinfos.ToList();   
        }

        [HttpGet]
        [Route("Pagination")]
        public ActionResult<List<EmpInfo>>getEmp(int page=1)

        {
            if (_Db.Empinfos == null)
            {
                return NotFound();
            }

            var pageSize = 5;
            var totalEmp = _Db.Empinfos.Count();
            var pageCount = Math.Ceiling(totalEmp /(double) pageSize);

            var empinfos = _Db.Empinfos
                .Skip((page-1)* (int)pageSize)
                .Take((int)pageSize)
                .ToList();

            var response = new EmpInfoRepo
            {
                Emps = empinfos,
                currentPage = page,
                totalPages = (int)pageCount
            };

            if (response.Emps.Count() == 0) 
              { return NotFound(); }
             
            return Ok(response);
        }
    }
}
