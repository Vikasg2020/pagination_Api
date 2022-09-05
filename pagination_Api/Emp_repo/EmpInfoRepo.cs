using pagination_Api.DB_Model;
using System.Collections.Generic;

namespace pagination_Api.Emp_repo
{
    public class EmpInfoRepo
    {

        public List<EmpInfo> Emps { get; set; } = new List<EmpInfo>() { };
        public int totalPages { get; set; }
        public int currentPage { get; set; }

    }
}
