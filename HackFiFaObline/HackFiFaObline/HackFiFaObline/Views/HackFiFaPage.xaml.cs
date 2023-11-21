using HackFiFaObline.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackFiFaObline.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HackFiFaPage : ContentPage
	{
		public HackFiFaPage ()
		{
			InitializeComponent ();
            BindingContext = new HackFiFaViewModel();
        }
        // Trong YourFirstPage.xaml.cs hoặc trong sự kiện Loaded/OnAppearing
    }
}