using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NetflixClone.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            NavigationPage.SetHasBackButton(this, false);
        
            InitializeComponent();

            var moviesPageObj = new NavigationPage(new MoviesPage())
            {
                Title = "Movies",
                Icon = "movis.png"
              
            };
            var searchPageObj = new NavigationPage(new SearchPage())
            {
                Title = "Search",
                Icon = "search.png"
            };

            var listPageObj = new NavigationPage(new MyListPage())
            {
                Title = "My List",
                Icon = "list.png"
            };
            var profilePageObj = new NavigationPage(new MyProfilePage())
            {
                Title = "My Profile",
                Icon = "profile.png"
            };
            Children.Add(moviesPageObj);
            Children.Add(searchPageObj);
            Children.Add(listPageObj);
            Children.Add(profilePageObj);
        }


    }
}
