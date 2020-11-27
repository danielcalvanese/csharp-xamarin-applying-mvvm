using Roster.Client.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public partial class HomeViewModel : INotifyPropertyChanged
    {
        public HomeViewModel()
        {
            UpdateApplicationCommand = new Command(UpdateApplicationExecute);
        }

        private string _title = "Roster App";
        public string Title {
            get { return _title; }
            set {
                _title = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Title)));
            }
        }

        public ObservableCollection<Person> People { get; } = new ObservableCollection<Person>() {
            new Person { Name = "Delores Feil", Company = "Legros Group" },
            new Person { Name = "Ann Zboncak", Company = "Ledner - Ferry" },
            new Person { Name = "Jaime Lesch", Company = "Herzog and Sons" }
        };

        public event PropertyChangedEventHandler PropertyChanged;

        public Command UpdateApplicationCommand { get; }
        private void UpdateApplicationExecute() {
            Title = "Roster App (v2.0)";
        }
    }
}
