using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirstApp.Repositories;
using FirstApp.Views;
using Xamarin.Forms;

namespace FirstApp
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "friends.db";
        public static FriendRepository database;
        public static FriendRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new FriendRepository(DATABASE_NAME);
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new FriendsListPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
