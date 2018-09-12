using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace SmashingRecipe
{
    public partial class RecipeEditPage : ContentPage
    {
        public event EventHandler<Recipe> RecipeSaved;

        Recipe TheRecipe { get; set; }
        bool IsNew { get; set; }

        public RecipeEditPage()
        {
            InitializeComponent();

            TheRecipe = new Recipe();
            IsNew = true;

            InitializePage();
        }

        public RecipeEditPage(Recipe recipe)
        {
            InitializeComponent();

            TheRecipe = recipe;
            IsNew = false;

            InitializePage();
        }

        void InitializePage()
        {
            Title = TheRecipe.Name ?? "New Recipe";

            recipeNameCell.Text = TheRecipe.Name;
            ingredientsCell.Text = TheRecipe.Ingredients;
            directionsCell.Text = TheRecipe.Directions;

            saveButton.Clicked += async (sender, args) =>
            {
                SaveRecipe();
                await CloseWindow();
            };

            cancelButton.Clicked += async (sender, args) =>
            {
                await CloseWindow();
            };
        }

        async Task CloseWindow()
        {
            if (IsNew)
                await Navigation.PopModalAsync(true);
            else
                await Navigation.PopAsync(true);
        }

        void SaveRecipe()
        {
            TheRecipe.Name = recipeNameCell.Text;
            TheRecipe.Ingredients = ingredientsCell.Text;
            TheRecipe.Directions = directionsCell.Text;

            if (IsNew)
            {
                TheRecipe.Id = Guid.NewGuid();
                App.AllRecipes.Add(TheRecipe);
            }
            else
            {
                var savedRecipe = App.AllRecipes.Find(r => r.Id == TheRecipe.Id);
                savedRecipe = TheRecipe;

                RecipeSaved?.Invoke(this, savedRecipe);
            }

        }
    }
}
