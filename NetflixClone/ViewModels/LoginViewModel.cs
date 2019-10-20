using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using NetflixClone.Pages;

namespace NetflixClone.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public INavigation navigation { get; set; }

        public Action ShowIncorrectLogin;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public string email;
        public string Email
        {
            get { return email;  }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));

            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            { 
                    password = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        public INavigation Navigation
        {
            get { return navigation; }
            set { navigation = value; }
        }

        public ICommand SubmitCommand { protected set; get; }

        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
        public void OnSubmit()
        {
            var homePage = new HomePage();
            Navigation.PushAsync(homePage);
        }
    }
}
