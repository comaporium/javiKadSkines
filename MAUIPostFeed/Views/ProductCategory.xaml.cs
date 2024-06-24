using MAUIPostFeed.Models;
using System.ComponentModel;

namespace MAUIPostFeed.Views;

public partial class ProductCategory : ContentPage, INotifyPropertyChanged
{
    public ProductCategory()
    {
        InitializeComponent();
        BindingContext = new Models.AllCategories();
    }

    async void categoryCollection_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            Category category = e.CurrentSelection.FirstOrDefault() as Category;
            var navigationParams = new Dictionary<string, object>
            {
                { "category", category }
            };
            await Shell.Current.GoToAsync($"{nameof(ProductList)}", navigationParams);

            categoryCollection.SelectedItem = null;
        }
    }
}
