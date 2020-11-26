using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Roster.Client.ViewModels
{
    public partial class HomeViewModel : INotifyPropertyChanged
    {
        public string Title { get; set; } = "Roster App";
        public event PropertyChangedEventHandler PropertyChanged;

        public Command UpdateApplicationCommand { get; }
    }
}
