using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NetflixClone.ViewModels;

namespace NetflixClone
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var vm = new LoginViewModel();
            vm.Navigation = Navigation;

            this.BindingContext = vm;
            vm.ShowIncorrectLogin += () => DisplayAlert("Error", "Invalid Login, try again", "OK");
            InitializeComponent();

            EmailEntry.Completed += (object sender, EventArgs e) =>
            {
                PasswordEntry.Focus();
            };

            PasswordEntry.Completed += (object sender, EventArgs e) =>
            {
                vm.SubmitCommand.Execute(null);
            };
        }
       
    }
}
