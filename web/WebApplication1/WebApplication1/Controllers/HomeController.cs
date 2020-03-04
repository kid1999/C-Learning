using System;
using System.Collections.Generic;
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
        [HttpGet]
        public IActionResult ViewTest(int id)
        {
            return View(_studentRepository.GetStudent(id));
        }

        public IActionResult ViewMore()
        {
            IEnumerable<Student> model = _studentRepository.GetStudents();
            return View(model);
        }

        [HttpPost]
        public JsonResult Create(Student student)
        {
            _studentRepository.AddStudent(student);
            return Json(_studentRepository.GetStudents());
        }
    }
}