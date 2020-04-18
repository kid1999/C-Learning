using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetHomeWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetHomeWork.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("togarde")]
        public IActionResult ScoreToGrade(int ? num)
        {
            int score = num ?? -1;
            if(score < 0) ViewBag.context = "";
            else if (score > 60) ViewBag.context = "优秀";
            else ViewBag.context = "不及格";
            return View();
        }


        [Route("tosort")]
        public IActionResult ToSort(String str)
        {
            String s = str ?? "";
            String res = "";
            string[] strs = s.Split(" ");
            List<int> list = new List<int>();
            if (s.Equals(""))
            {
                 res = "";
            }
            else
            {
                for (int i = 0; i < strs.Length; i++)
                {
                    list.Add(int.Parse(strs[i]));
                }
                list.Sort();

                foreach (int num in list)
                {
                    res += " " + num;
                }
            }
            ViewBag.res = res;
            return View();
        }


        [Route("calculator")]
        public IActionResult ToCalculator(double? a, double? b)
        {
            double num1 = a ?? 0;
            double num2 = b ?? 0;
            string res = "";
            if (b == 0) res = "请输入正确的数字！";
            else
            {
                res = "" + (a / b);
            }
            ViewBag.res = res;
            return View();
        }

        [Route("birthday")]
        public IActionResult ToBirthday(string name,DateTime birthday)
        {
            UserInfo people = new UserInfo();
            people.Name = name ?? "";
            people.Birthday = birthday;
            String word = "";
            Console.WriteLine(people.Name);
            if (DateTime.Now.Year - people.Birthday.Year >= 18)
            {
                word = people.Name + "," + "你已经成年了！";
            }
            else
            {
                word = people.Name + "," + "你还小！";
            }
            ViewBag.res = word;
            
            return View();
        }

    }

}