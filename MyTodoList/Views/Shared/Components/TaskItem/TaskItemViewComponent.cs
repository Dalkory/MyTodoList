using Microsoft.AspNetCore.Mvc;
using MyTodoList.Domain.Entities;

namespace MyTodoList.Views.Shared.Components.TaskItem
{
    public class TaskItemViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(TaskApp task)
        {
            return View(task);
        }
    }
}
