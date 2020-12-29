using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using studentManagement.models;
using studentManagement.viewModels;

namespace studentManagement.controllers
{
    public class HomeController : Controller
    {
        public  StudentRepository _studentRepository;

        public HomeController(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;

        }
        public IActionResult Index()
        {
            IEnumerable<Student> enumerable = _studentRepository.GetStudents();
            HomeIndexViewModels homeIndexViewModels = new HomeIndexViewModels() {
                stuList = enumerable.ToList(),
                title="学生列表"
            };
            return View(homeIndexViewModels);
        }

        public IActionResult Test(int id)
        {
            Student student = _studentRepository.GetStudent(1);
            return View(student);


        }
    }
}
