using System;
using MvvmCross.Core.ViewModels;
using ListIOSXamarinMVVMCross.Model;
using System.Collections.Generic;

namespace ListIOSXamarinMVVMCross.ViewModels
{
    public class ListViewModel : MvxViewModel
    {
        public ListViewModel()
        {
            _persons = new List<Person>
            {
            new Person() { Name = "Ivan", Surname = "Sidorov" },
            new Person() { Name = "Petr", Surname = "Ivanov" },
            new Person() { Name = "Matvey", Surname = "Kozlov" },
            };
            //ShowViewModel<ListViewModel>(Persons);
        }

        private List<Person> _persons;
        public List<Person> Persons
        {
            get { return _persons; }
            set
            {
                _persons = value;
                RaisePropertyChanged(() => Persons);
            }
        }

        //private MvxCommand _command;
        //public MvxCommand Command
        //{
        //    get
        //    {
        //        return new MvxCommand(() => )
        //    }
        //}

    }
}
