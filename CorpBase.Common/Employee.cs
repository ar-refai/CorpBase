using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorpBase.Common
{
    public class Employee
    {
        public int Id{ get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }

        // Foreign Key
        public int DepartmentId {get;set;}
    }
}
