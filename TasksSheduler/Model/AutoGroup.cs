using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AutoGroup
    {
        public string AGroup { get; set; }
        public ObservableCollection<UserTask> UserTasks { get; set; }
            
    }
}
