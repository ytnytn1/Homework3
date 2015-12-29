using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserTask
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        public enum TaskStatus
        {
            [Description("Новая")]
            New,
            [Display(Name = "Выполняется")]
            InProgress,
            [Display(Name = "Отложена")]
            Postponded,
            [Display(Name = "Завершена")]
            Completed,
            [Display(Name = "Отменена")]
            Canceled
        }

        public TaskStatus Status { get; set; }
        public string Group { get; set; }
    }
}
