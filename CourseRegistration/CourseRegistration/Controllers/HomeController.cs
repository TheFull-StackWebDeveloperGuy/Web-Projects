using CourseRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CourseRegistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Instructor()
        {
            InstructorViewModel avm = new();
            List<DTO.Instructor> instructors = new List<DTO.Instructor>()
                {
                new DTO.Instructor{ Id = 1001, Firstname = "Joe", Lastname = "Friala", Email = "jfriala@example.com" },
                new DTO.Instructor{ Id = 1002, Firstname = "Mak", Lastname = "Alagao", Email = "malagao@example.com" },
                new DTO.Instructor{ Id = 1003, Firstname = "Gibibo", Lastname = "Tacnay", Email = "gtacnay@example.com" }
                };
            avm.Instructors = instructors;
            return View(avm);
        }
        public IActionResult Student()
        {
            StudentViewModel avm = new();
            List<DTO.Student> students = new List<DTO.Student>()
                {
                new DTO.Student{ Id = 10001, Firstname = "Lorraine", Lastname = "Lagonera", Email = "Llagonera@example.com", Phone="401-1234-567" },
                new DTO.Student{ Id = 10002, Firstname = "Aaron", Lastname = "Lagonera", Email = "Aalagonera@example.com", Phone="402-1234-567" },
                new DTO.Student{ Id = 10003, Firstname = "Alecza", Lastname = "Lagonera", Email = "Aleclagonera@example.com", Phone="403-1234-567" },
                new DTO.Student{ Id = 10004, Firstname = "Eros", Lastname = "Lagonera", Email = "Eroslagonera@example.com", Phone="404-1234-567" },
                new DTO.Student{ Id = 10005, Firstname = "Deanne Allexa", Lastname = "Rante", Email = "deallexarante@example.com", Phone="405-1234-567" },
                new DTO.Student{ Id = 10006, Firstname = "Cyril Jade", Lastname = "Avila", Email = "cjavila@example.com", Phone="406-1234-567" }
                };
            avm.Students = students;
            return View(avm);
        }
        public IActionResult Course()
        {
            CourseViewModel avm = new();
            List<DTO.Course> courses = new List<DTO.Course>()
                {
                new DTO.Course{ Id = "A01001", Coursenumber = "TA01", Coursename = "HTML/CSS", Description = "HTML and CSS, the inseparable duo of the software world, is an indispensable part of front-end" +
                "developer advertisements. HTML, HyperText Markup Language, is of great importance in the software world. Knowledge of these languages is critical for websites to be created in a basic sense." },
                new DTO.Course{ Id = "A02001", Coursenumber = "TA02", Coursename = "JavaScript / jQuery", Description = "Another thing front-end developers should know is JavaScript (JS). While sometimes the " +
                "stylish presentation of the content of a page is sufficient for a successful web design, you may need interactive features on some websites. At this point, JavaScript rushes to help" },
                new DTO.Course{ Id = "A03001", Coursenumber = "TA03", Coursename = " Version Control", Description ="While developing the codes you write with HTML, CSS, and JS, you will have many " +
                "versions in your hands. This is so normal. If something goes wrong during your studies, the last thing you want to do is start writing all the code from scratch. Version control keeps track " +
                "of your changes and allows you to access previous versions easily. The version control software can help you do this." }
                };
            avm.Courses = courses;
            return View(avm);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}