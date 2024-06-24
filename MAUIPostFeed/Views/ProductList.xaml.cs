using MAUIPostFeed.Models;
using System.ComponentModel;

namespace MAUIPostFeed.Views;

[QueryProperty(nameof(Category), "category")]
public partial class ProductList : ContentPage, IQueryAttributable, INotifyPropertyChanged
{
    public Category Category { get; private set; }

    public ProductList()
    {
        InitializeComponent();
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.ContainsKey("category"))
        {
            Category = query["category"] as Category;
            BindingContext = new Models.AllProducts(Category.title);
            OnPropertyChanged(nameof(Category));
        }
    }

    async void productsCollection_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            Product product = e.CurrentSelection.FirstOrDefault() as Product;
            var navigationParams = new Dictionary<string, object>
            {
                { "product", product }
            };
            await Shell.Current.GoToAsync("ProductDetails", navigationParams);

            productsCollection.SelectedItem = null;
        }
    }
}
