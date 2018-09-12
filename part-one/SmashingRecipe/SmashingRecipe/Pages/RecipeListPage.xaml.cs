using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SmashingRecipe
{
    public partial class RecipeListPage : ContentPage
    {
        //public List<Recipe> AllRecipes { get; set; }

        public RecipeListPage()
        {
            InitializeComponent();

            //AllRecipes = new List<Recipe>();
            //AllRecipes.Add(new Recipe { Name = "Buns", Ingredients = "Love and some other stuff", Directions = "You're going to have to read on and on and on and on and on and on and on and on and on and on and on and on You're going to have to read on and on and on and on and on and on and on and on and on and on and on and on" });
            //AllRecipes.Add(new Recipe { Name = "Coleslaw" });
            //AllRecipes.Add(new Recipe { Name = "Baked Beans" });

            //recipesList.ItemsSource = App.AllRecipes;

            recipesList.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    var detailPage = new RecipeDetailPage(e.SelectedItem as Recipe);

                    await Navigation.PushAsync(detailPage);

                    recipesList.SelectedItem = null;
                }
            };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            recipesList.ItemsSource = null;
            recipesList.ItemsSource = App.AllRecipes;
        }

        async void Add_Clicked(object sender, System.EventArgs e)
        {
            var editPage = new RecipeEditPage();

            await Navigation.PushModalAsync(new NavigationPage(editPage));
        }
    }
}
