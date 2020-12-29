using studentManagement.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentManagement.viewModels
{
    public class HomeIndexViewModels
    {
        public List<Student> stuList {get; set;}
        public string title { get; set; }
    }
}
