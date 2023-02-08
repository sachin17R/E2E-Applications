using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeApplication.ViewModelFolder
{
    public class ViewModelClass
    {
        public int EmpId { get; set; }


        [Required(ErrorMessage ="Enter Something",AllowEmptyStrings =false)]
        public string Name { get; set; }


        [Required(ErrorMessage ="Enter Something",AllowEmptyStrings =false)]
        [MinLength(4,ErrorMessage ="Data should Be More Than 4 chars")]
        public string Address { get; set; }



        [Range(minimum:10000,maximum:100000,ErrorMessage ="Sal Should Between The Range 10000 to 100000")]
        public int salary { get; set; }


        public int deptId { get; set; }
    }
}