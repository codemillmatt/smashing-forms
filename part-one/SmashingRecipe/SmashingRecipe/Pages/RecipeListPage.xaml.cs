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

            var editNavPage = new NavigationPage(editPage)
            {
                BarBackgroundColor = Color.FromHex("#01487E"),
                BarTextColor = Color.White
            };

            await Navigation.PushModalAsync(editNavPage);
        }
    }
}
