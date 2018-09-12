using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SmashingRecipe
{
    public partial class RecipeDetailPage : ContentPage
    {
        Recipe TheRecipe { get; set; }

        public RecipeDetailPage(Recipe recipe)
        {
            InitializeComponent();

            TheRecipe = recipe;

            BindingContext = TheRecipe;
        }

        async void Edit_Clicked(object sender, System.EventArgs e)
        {
            var editPage = new RecipeEditPage(TheRecipe);

            editPage.RecipeSaved += (page, recipe) =>
            {
                BindingContext = null;
                TheRecipe = recipe;
                BindingContext = TheRecipe;
            };

            await Navigation.PushAsync(editPage);
        }
    }
}
