using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFImageLoadingTransformationsExemplo.ViewModel;
using Xamarin.Forms;

namespace FFImageLoadingTransformationsExemplo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            BindingContext = new MainViewModel();
		}
	}
}
