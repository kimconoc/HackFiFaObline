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
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            //Binding dữ liệu lên BaseViewModel
            BindingContext = new LoginViewModel();
        }
        private void TogglePasswordVisibility(object sender, EventArgs e)
        {
            if (passwordEntry != null)
            {
                passwordEntry.IsPassword = !passwordEntry.IsPassword;
            }
        }
    }
}