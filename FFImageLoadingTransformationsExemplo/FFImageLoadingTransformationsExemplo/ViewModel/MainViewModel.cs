using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FFImageLoadingTransformationsExemplo.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public string ImageUrl { get; set; }

        public MainViewModel()
        {
            ImageUrl = @"https://raw.githubusercontent.com/TBertuzzi/FFImageLoadingTransformationsExemplo/master/Resources/zelda.png";


        }

        // INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        void RaisePropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
