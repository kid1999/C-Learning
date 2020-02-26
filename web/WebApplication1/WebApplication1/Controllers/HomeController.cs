using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        // 依赖注入
        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        // 返回字符串
        public String Index()
        {
            return _studentRepository.GetStudent(1).Name;
        }

        // 返回json
        public JsonResult Json()
        {
            return Json(_studentRepository.GetStudent(1));
        }

        // 返回视图
        public IActionResult ViewTest()
        {
            return View(_studentRepository.GetStudent(1));
        }

        public IActionResult ViewMore()
        {
            IEnumerable<Student> model = _studentRepository.GetStudents();
            return View(model);
        }
    }
}