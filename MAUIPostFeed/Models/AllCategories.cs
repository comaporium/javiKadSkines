using System.Collections.ObjectModel;

namespace MAUIPostFeed.Models
{
    public class AllCategories
    {
        public ObservableCollection<Category> Categories { get; set; } = new ObservableCollection<Category>();

        public AllCategories() =>
            LoadProducts();

        public void LoadProducts()
        {
            ObservableCollection<Category> categories = new ObservableCollection<Category>
            {
                new Category
                {
                    id = 1,
                    title = "Svi uređaji",
                    thumbnail = "https://media.istockphoto.com/id/1037445450/vector/abstract-bright-blue-glitter-lines-background-with-glittery-shine-motion-speed-stripes.jpg?s=612x612&w=0&k=20&c=AC7EkgnHEELmGOJ3RcWHZCElh3edgQZmBlqvE02DQdA="
                },
                new Category
                {
                    id = 2,
                    title = "Mobiteli",
                    thumbnail = "https://d11a6trkgmumsb.cloudfront.net/original/3X/8/6/86b938d3495c60196d744ce5f876bde0c959e9cd.jpg"
                },
                new Category
                {
                    id = 3,
                    title = "Tableti",
                    thumbnail = "https://img.freepik.com/free-photo/young-businesswoman-working-with-pc-tablet-consulting-smartphone_1262-16647.jpg"
                },
                new Category
                {
                    id = 4,
                    title = "PC/Laptop",
                    thumbnail = "https://img.freepik.com/free-photo/office-desktop-with-laptop-analytics_23-2148174053.jpg"
                },
                new Category
                {
                    id = 5,
                    title = "Satovi",
                    thumbnail = "https://media.istockphoto.com/id/1322886097/photo/female-hand-with-smart-watch-with-black-blank-screen.jpg?s=612x612&w=0&k=20&c=Rzrs02yVeb3B8PuxXhnlhHWyOvbhVlsPA0fEbPV6uwE="
                }
            };

            for (int i = 0; i < categories.Count; i++)
            {
                Categories.Add(categories[i]);
            }
        }
    }
}

