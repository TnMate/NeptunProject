using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tanulmanyi2._0.Models;

namespace Tanulmanyi2._0.Controllers
{
    public class HomeController : Controller
    {

        private readonly TanulmanyiContext _context;          // singleton representation of the database

        public HomeController(TanulmanyiContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string ChoosenTraining, string SearchString, string SearchString2)
        {
            IQueryable<string> trainingQuery = from m in _context.Trainings orderby m.Name select m.Name;
            // lekérdezni a trainingeket, s azokat belerakni legördülő listába
            var HomeView = new HomeViewModel();
            HomeView.trainings = new SelectList(await trainingQuery.Distinct().ToListAsync());
            HomeView.CourseName = SearchString;

            HomeView.instructors = await (from m in _context.Instructors select m).ToListAsync();

            if (!String.IsNullOrEmpty(ChoosenTraining) )
            {
                var thisTraining = await _context.Trainings.FirstOrDefaultAsync(m => m.Name == ChoosenTraining);

                HomeView.ChoosenTraining = ChoosenTraining;
                if (!String.IsNullOrEmpty(SearchString) && !String.IsNullOrEmpty(SearchString2))
                {
                    HomeView.courses =
                        await (from m in _context.Courses
                               orderby m.Name
                               where m.TrainingId == thisTraining.Id
                               && m.Name.Contains(SearchString)
                               && m.Instructor.Name.Contains(SearchString2)
                               select m).ToListAsync();
                }
                else if (!String.IsNullOrEmpty(SearchString2))
                {
                    HomeView.courses =
                        await (from m in _context.Courses
                               orderby m.Name
                               where m.TrainingId == thisTraining.Id
                               && m.Instructor.Name.Contains(SearchString2)
                               select m).ToListAsync();
                }
                else if (!String.IsNullOrEmpty(SearchString))

                {
                    HomeView.courses =
                        await (from m in _context.Courses
                               orderby m.Name
                               where m.TrainingId == thisTraining.Id
                               && m.Name.Contains(SearchString)
                               select m).ToListAsync();
                }
                else
                {
                    HomeView.courses =
                        await (from m in _context.Courses
                               orderby m.Name
                               where m.TrainingId == thisTraining.Id
                               select m).ToListAsync();
                }

            }
            return View(HomeView);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
