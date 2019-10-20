using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NetflixClone.Pages
{
    public partial class MoviesPage: ContentPage
    {
        public MoviesPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
    }
}
