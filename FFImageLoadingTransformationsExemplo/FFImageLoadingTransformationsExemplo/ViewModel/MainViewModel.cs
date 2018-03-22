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
            ImageUrl = @"https://raw.githubusercontent.com/recurser/exif-orientation-examples/master/Landscape_3.jpg";
        }

        // INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        void RaisePropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
