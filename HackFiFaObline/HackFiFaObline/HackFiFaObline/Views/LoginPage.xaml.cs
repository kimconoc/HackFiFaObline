using HackFiFaObline.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
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

        private async void OpenWebsite_Click(object sender, EventArgs e)
        {
            // Đường dẫn đến trang web bạn muốn mở
            string url = "http://kichhoatkey.top/";
            // Mở trình duyệt mặc định với liên kết đến trang web
            await Browser.OpenAsync(url);
        }
    }
}