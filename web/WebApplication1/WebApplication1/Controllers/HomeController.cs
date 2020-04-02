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
            return "Hello world";
        }

        // 返回json
        public JsonResult Json()
        {
            return Json(_studentRepository.GetStudent(1));
        }

        // 返回视图

        //弱类型视图 
        public IActionResult ViewTest2()
        {
            ViewBag.context = "弱类型视图内容";
            return View();
        }
        // 强类型视图
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

        // 使用全局模板 
        // 自定义 layout
        public IActionResult ViewLayout()
        {
            return View();
        }

        // viewStart控制 layout
        public IActionResult ViewStart()
        {
            return View();
        }

        // 自定义路由
        [Route("test/{id?}")]
        public IActionResult ViewRouter(int? id)
        {
            ViewBag.id = id ?? 1;
            return View();
        }

        // post 方法
        [HttpPost]
        public JsonResult Create(Student student)
        {
            _studentRepository.AddStudent(student);
            return Json(_studentRepository.GetStudents());
        }
    }
}