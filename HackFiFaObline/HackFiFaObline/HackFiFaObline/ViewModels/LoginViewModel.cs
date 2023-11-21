using HackFiFaObline.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace HackFiFaObline.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand Login { get; private set; }
        public LoginViewModel()
        {
            Title = "Hack FIFA Online 4 ProV1.2";
            Login = new Command(ExecuteLoginCommand);
        }

        private string _account = string.Empty;
        public string Account
        {
            get { return _account; }
            set { SetProperty(ref _account, value); }
        }
        private string _codeActive = string.Empty;
        public string CodeActive
        {
            get { return _codeActive; }
            set { SetProperty(ref _codeActive, value); }
        }
        private async void ExecuteLoginCommand()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new HackFiFaPage());
            //if (Account.ToLower() == "ducpv" && CodeActive == "123")
            //{
            //    await Application.Current.MainPage.Navigation.PushAsync(new HackFiFaPage());
            //    //var pageIndex = Application.Current.MainPage.Navigation.NavigationStack.Count;
            //    //Application.Current.MainPage.Navigation.RemovePage(Application.Current.MainPage.Navigation.NavigationStack[Application.Current.MainPage.Navigation.NavigationStack.Count - pageIndex]);
            //}    
        }
    }
}
