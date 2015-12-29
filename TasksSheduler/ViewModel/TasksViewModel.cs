using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Model;
using ViewModel.Annotations;

namespace ViewModel
{
    public class TasksViewModel: ViewModelBase1
    {
        private UserTask _selectedGroup;
        private bool _isComplited;
        private bool _isCancelled;

        public TasksViewModel()
        {
            var userTasks = new ObservableCollection<UserTask>
            {
                new UserTask
                {
                    Name = "Подарить подарок Володе",
                    Description = "какой-то подарок",
                    DueDate = new DateTime(2016, 02, 18),
                    Status = UserTask.TaskStatus.New,
                }
            };
             AutoGroupes = new ObservableCollection<AutoGroup>
            {
                new AutoGroup
                {
                    AGroup = "Завершенные"
                },
                new AutoGroup
                {
                    AGroup = "Просроченные"
                }
            };

            AutoGroupes[0].UserTasks = userTasks;
            AutoGroupes[1].UserTasks = userTasks;
            
        }
        public ObservableCollection<AutoGroup> AutoGroupes { get; set; }

        //public ObservableCollection<UserTask> UserTasks { get; set; } = new ObservableCollection<UserTask>

        //{
        //    new UserTask
        //    {
        //        Name = "Подарить подарок Володе",
        //        Description = "какой-то подарок",
        //        DueDate = new DateTime(2016, 02, 18),
        //        Status = UserTask.TaskStatus.New,
        //    }
        //};
        
        //    },
        //    new UserTask
        //    {
        //        Name = "Заспойлерить Звездные Войны",
        //        Description = "Заспойлерить сметь Хана Соло",
        //        DueDate = new DateTime(2016,01,1),
        //        Status = UserTask.TaskStatus.New
        //    },
        //    new UserTask
        //    {
        //        Name = "Посмотреть звездные войны",
        //        Description = "сходить на премьеру",
        //        DueDate = new DateTime(2015,12,17),
        //        Status = UserTask.TaskStatus.New
        //    },
        //    new UserTask
        //    {
        //        Name = "Подготовиться к экзамену по ООП",
        //        Description = "повторить основные темы",
        //        DueDate = new DateTime(2016,02,18),
        //        Status = UserTask.TaskStatus.New
        //    },
        //    new UserTask
        //    {
        //        Name = "Подготовиться к экзамену по WPF",
        //        Description = "повторить основные тему",
        //        DueDate = new DateTime(2016,02,19),
        //        Status = UserTask.TaskStatus.New
        //    },
        //    new UserTask
        //    {
        //        Name = "Закрыть сессию досрочно",
        //        Description = "сдать все экзамены",
        //        DueDate = new DateTime(2016,01,2),
        //        Status = UserTask.TaskStatus.New
        //    },

        //};


        private UserTask _selectedTask;
        public UserTask SelectedTask
        {
            get { return _selectedTask; }
            set { _selectedTask = value; }
        }

        public UserTask SelectedGroup
        {
            get { return _selectedGroup; }
            set { _selectedGroup = value; }
        }

        public void AddNewTask(string name, string description, DateTime dueDate, TaskStatus status, string group)
        {
            var newTask = new UserTask
            {
                Name = name,
                Description = description,
                DueDate = dueDate,
                Status = (UserTask.TaskStatus)status,
            };
            //UserTasks.Add(newTask);
        }

        public void AddNewGroup(string group)
        {
            var newGroup = new UserTask
            {
                Group = group
            };
            //UserTasks.Add(newGroup);
        }

        public bool IsComplited
        {
            get { return _isComplited; }
            set
            {
                _isComplited = value;
                OnPropertyChanged();
            }
        }
        public bool IsCancelled
        {
            get { return _isCancelled; }
            set
            {
                _isCancelled = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
