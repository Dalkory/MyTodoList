using MyTodoList.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace MyTodoList.Models.Home
{
    public class HomeViewModel
    {
        [Required(ErrorMessage = "Данное поле обяхательно")]
        public string? TaskName { get; set; }

        [Required(ErrorMessage = "Данное поле обяхательно")]
        public DateTime? DateTime { get; set; }

        public IEnumerable<TaskApp>? Tasks { get; set; }
    }
}
