using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MyTodoList.Controllers
{
    public abstract class MyTodoBaseController : Controller
    {
        protected int CurrentUserId => int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
    }
}
