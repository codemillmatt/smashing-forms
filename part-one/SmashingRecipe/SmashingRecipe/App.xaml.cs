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
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "Buns", Ingredients = "Love and some secret stuff", Directions = @"Surely I'm not going to give away family secrets in this article!!" });
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "Coleslaw" });
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "Baked Beans" });
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "Black Forest Ham" });
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "Best Chicken You've Ever Tasted" });
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "This Chicken Is Even Better!" });
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "Hot Potato Salad" });
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "Homemade Brats" });
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "Gumbo" });
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "Rhubarb Pie" });
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "Cherry Bounce" });
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "Ranch Chicken" });
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "Veggie Lentil Soup" });
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "Poached Eggs with Yogurt" });
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "Spicy Roasted Chickpeas" });
            AllRecipes.Add(new Recipe { Id = Guid.NewGuid(), Name = "Fudgy Avocado Brownies" });

            var np = new NavigationPage(new RecipeListPage());
            np.BarBackgroundColor = Color.FromHex("#01487E");
            np.BarTextColor = Color.White;
            MainPage = np;
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
