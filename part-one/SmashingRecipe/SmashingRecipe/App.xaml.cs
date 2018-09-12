using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SmashingRecipe
{
    public partial class App : Application
    {
        public static List<Recipe> AllRecipes { get; set; }

        public App()
        {
            InitializeComponent();

            AllRecipes = new List<Recipe>();
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "Buns", Ingredients = "Love and some other stuff", Directions = "You're going to have to read on and on and on and on and on and on and on and on and on and on and on and on You're going to have to read on and on and on and on and on and on and on and on and on and on and on and on" });
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "Coleslaw" });
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "Baked Beans" });

            MainPage = new NavigationPage(new RecipeListPage());
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
