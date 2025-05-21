using Microsoft.AspNetCore.Mvc;
using LAB2.Models;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        private static List<Todo> todos = new List<Todo>
        {
            new Todo { Id = 1, Task = "Ôn tập HTML" },
            new Todo { Id = 2, Task = "Ôn tập CSS" },
            new Todo { Id = 3, Task = "Ôn tập Bootstrap" }
        };

        public IActionResult Index()
        {
            return View(todos);
        }

        // Action Add
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Todo todo)
        {
            todo.Id = todos.Max(t => t.Id) + 1;
            todos.Add(todo);
            return RedirectToAction("Index");
        }

        // Action Edit
        public IActionResult Edit(int id)
        {
            var todo = todos.FirstOrDefault(t => t.Id == id);
            return View(todo);
        }

        [HttpPost]
        public IActionResult Edit(Todo updatedTodo)
        {
            var todo = todos.FirstOrDefault(t => t.Id == updatedTodo.Id);
            if (todo != null)
            {
                todo.Task = updatedTodo.Task;
            }
            return RedirectToAction("Index");
        }
    }
}
