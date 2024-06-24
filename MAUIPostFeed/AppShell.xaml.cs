using MAUIPostFeed.Views;

namespace MAUIPostFeed;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("ProductDetails", typeof(ProductDetails));
		Routing.RegisterRoute("ProductList", typeof(ProductList));
	}
}

