using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace LearnXamarin.ViewModels
{
    public class DetailPageViewModel : INotifyPropertyChanged
    {
        public DetailPageViewModel()
        {
            ExitCommand = new Command(async () => await Application.Current.MainPage.Navigation.PopAsync());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        string noteText;

        public string NoteText
        {
            get { return noteText; }
            set 
            {
                noteText = value;

                var args = new PropertyChangedEventArgs(nameof(NoteText));

                PropertyChanged?.Invoke(this, args);
            }
        }

        public Command ExitCommand { get; }

    }
}
