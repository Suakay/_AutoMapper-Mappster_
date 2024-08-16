using _AutoMapper__.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _AutoMapper__.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMapper _mapper;
        public HomeController(ILogger<HomeController> logger ,IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            Class sinif =new Class();
            sinif.Name = "HS";
            Student student1 = new Student()
            {
                Id = Guid.NewGuid(),
                FirstName = "Renzi",
                LastName = "Urhan",
                Age = 30,

            };

            var studenVM=_mapper.Map<StudentVM>(student1);
            /*
            StudentVM studentVM = new StudentVM();
            studentVM.Id = student.Id;
            studentVM.FirstName = student.FirstName;
            studentVM.LastName = student.LastName;
            studentVM.Age = student.Age;*/

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
