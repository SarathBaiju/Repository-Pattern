using System;
using System.Linq.Expressions;
using Hangfire;
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
           // some();
            return View(_repository.GetStudents());
        }
        [Queue("Students")]
        private Expression<Action<string>> some()
        {
            for (int i = 0; i < 10; i++)
            {
                BackgroundJob.Enqueue<IRepository>(s => s.GetStudents());
            }
            return null;
        }
    }
}