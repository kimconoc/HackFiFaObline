using HackFiFaObline.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HackFiFaObline.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand Login { get; private set; }
        public LoginViewModel()
        {
            Title = "Hack Trên Điện Thoại ProVIP";
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
        private bool _isShowNotification = false;
        public bool IsShowNotification
        {
            get { return _isShowNotification; }
            set { SetProperty(ref _isShowNotification, value); }
        }
        private string _textNotification = string.Empty;
        public string TextNotification
        {
            get { return _textNotification; }
            set { SetProperty(ref _textNotification, value); }
        }
        private async void ExecuteLoginCommand()
        {
            IsBusy = true;
            await Task.Delay(500);
            IsBusy = false;
            IsShowNotification = true;
            if (!string.IsNullOrEmpty(Account) && !string.IsNullOrEmpty(CodeActive))
            {
                TextNotification = "Mã kích hoạt sai vui lòng thử lại!";
            }
            else
            {
                TextNotification = "Vui lòng điền đầy đủ thông tin!";
            }    
            await HideNotificationAfterDelay();
               
        }
        private async Task HideNotificationAfterDelay()
        {
            // Đợi 3 giây (3000 milliseconds)
            await Task.Delay(3000);
            // Sau đó, đặt giá trị của IsShowNotification thành false
            IsShowNotification = false;
        }

    }
}
