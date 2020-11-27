using System;
using System.Collections.Generic;
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
        public event PropertyChangedEventHandler PropertyChanged;

        public Command UpdateApplicationCommand { get; }
        private void UpdateApplicationExecute() {
            Title = "Roster App (v2.0)";
        }
    }
}
