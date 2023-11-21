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
        private void ExecuteLoginCommand()
        {
            if(Account.ToLower() == "ducpv" && CodeActive == "123")
            {

            }    
        }
    }
}
