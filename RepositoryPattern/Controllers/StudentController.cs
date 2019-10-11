using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.DataAccess;

namespace RepositoryPattern.Controllers
{
    public class StudentController : Controller
    {
        private readonly IRepository _repository;
        public StudentController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {           
            return View(_repository.GetStudents());
        }
    }
}