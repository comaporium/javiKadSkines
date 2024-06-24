using System.Collections.ObjectModel;

namespace MAUIPostFeed.Models
{
    public class AllProducts
    {
        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>();

        public AllProducts(string category) =>
            LoadProducts(category);

        public void LoadProducts(string category)
        {
            ObservableCollection<Product> products = new ObservableCollection<Product>
            {
                new Product
                {
                    id = 1,
                    title = "Smart Watch K11",
                    description = "Kieslect K11 Pro je IP68 vodootporan, možete ga bezbrižno nositi dok perete ruke ili vježbate.\r\n\r\nMože zadovoljiti dnevne vodonepropusne potrebe za znojenjem, kišom, pranjem itd.\r\n\r\nNe podržava surfanje, saunu i ronjenje.\r\n\r\nNakon prskanja, obrišite mrlje od vode prije rada kako biste održali vijek trajanja.",
                    price = 179,
                    discountPercentage = 30,
                    rating = 4.94,
                    stock = 5,
                    brand = "Kieslect",
                    category = "Satovi",
                    thumbnail = "https://www.univerzalno.com/wp-content/uploads/2024/03/Kieslect-Smart-Watch-K11-Pro-black-1.jpg",
                    images = new List<string>
                    {
                        "https://www.univerzalno.com/wp-content/uploads/2024/03/Kieslect-Smart-Watch-K11-Pro-black-1.jpg",
                        "https://www.univerzalno.com/wp-content/uploads/2024/03/Kieslect-Smart-Watch-K11-Pro-black.jpg",
                        "https://www.univerzalno.com/wp-content/uploads/2024/03/Kieslect-Smart-Watch-K11-Pro-black-3.jpg",
                        "https://www.univerzalno.com/wp-content/uploads/2024/03/Kieslect-Smart-Watch-K11-Pro-black-2.jpg"
                    }
                },
                new Product
                {
                    id = 2,
                    title = "Apple iPhone 15 Pro",
                    description = "iPhone 15 Pro/iPhone 15 Pro Max modeli stižu uz OLED ekrane veličine 6.1/6.7″, sa brzinom osvježavanja slike od 120 Hz. Dynamic Island je standard na Pro modelima još od prethodne generacije, a najveća novost je okvir telefona izrađen od titanijuma, što ovu seriju čini najlakšim Pro modelima ikad. Pokreće je chipset Apple A17 Pro, izrađen u tehnologiji od 3nm. Donosi procesor sa šest jezgri, a iz Applea najavljuju nevjerovatne performanse.",
                    price = 2490,
                    discountPercentage = 20,
                    rating = 4.28,
                    stock = 12,
                    brand = "Apple",
                    category = "Mobiteli",
                    thumbnail = "https://www.univerzalno.com/wp-content/uploads/2023/10/iphone15pro1.jpg",
                    images = new List<string>
                    {
                        "https://www.univerzalno.com/wp-content/uploads/2023/10/iphone15pro1.jpg",
                        "https://www.univerzalno.com/wp-content/uploads/2023/10/iphone15pro6.jpg"
                    }
                },
                new Product
                {
                    id = 3,
                    title = "Laptop HP 250 G10, 853R0ES",
                    description = "Intel Core i3 1315U, 12GB DDR4 RAM, 512GB SSD, Intel UHD Graphics, 15.6″ 1920 x 1080 display, 720p HD camera, Wi-Fi 6 (2×2) and Bluetooth 5.3, 1x USB Type-C 5Gbps signaling rate, 2x USB Type-A 5Gbps signaling rate, 1x AC power, 1x HDMI 1.4b, 1x stereo headphone/microphone combo jack, Battery: 41Wh, Težina: 1.52kg, Boja: Crna",
                    price = 1097,
                    discountPercentage = 5,
                    rating = 4.7,
                    stock = 6,
                    brand = "HP",
                    category = "PC/Laptop",
                    thumbnail = "https://www.univerzalno.com/wp-content/uploads/2024/06/HP-250-G10-laptop-853R0ES-2.webp",
                    images = new List<string>
                    {
                        "https://www.univerzalno.com/wp-content/uploads/2024/06/HP-250-G10-laptop-853R0ES-2.webp",
                        "https://www.univerzalno.com/wp-content/uploads/2024/06/HP-250-G10-laptop-853R0ES-3.webp",
                        "https://www.univerzalno.com/wp-content/uploads/2024/06/HP-250-G10-laptop-853R0ES-4.webp"
                    }
                },
                new Product
                {
                    id = 4,
                    title = "POCO X6 Pro 5G",
                    description = "Dijagonala 6.67 inča\r\nOLED\r\nRezolucija 1220 x 2712 točaka\r\nGustoća (ppi) 446 ppi\r\nPostotak prednje površine 90.32 %",
                    price = 650,
                    discountPercentage = 18,
                    rating = 3.82,
                    stock = 14,
                    brand = "Xiaomi",
                    category = "Mobiteli",
                    thumbnail = "https://www.univerzalno.com/wp-content/uploads/2024/06/poco-x6-pro.jpg",
                    images = new List<string>
                    {
                        "https://www.univerzalno.com/wp-content/uploads/2024/06/poco-x6-pro.jpg",
                        "https://www.univerzalno.com/wp-content/uploads/2024/06/5d7f7747bc169025dbfd475c9d43fb58800x80085.png"
                    }
                },
                new Product
                {
                    id = 5,
                    title = "GARMIN VENU SQ 2 MUSIC",
                    description = "Pronađite novi način za kretanje uz Venu® Sq 2. Ovaj GPS pametni sat sa svijetlim AMOLED displejom i baterijom koja traje i do 11 dana kombinuje svakodnevni stil s acjelodnevnim praćenjem zdravlja i fitness funkcijama kako biste povezali svoj um i tijelo.",
                    price = 616,
                    discountPercentage = 5,
                    rating = 4,
                    stock = 11,
                    brand = "Garmin",
                    category = "Satovi",
                    thumbnail = "https://www.univerzalno.com/wp-content/uploads/2024/06/GARMIN-Venu-Sq-2-Music-Ivory-Peach-Gold-M-BIKE-SHOP-1.jpg",
                    images = new List<string>
                    {
                        "https://www.univerzalno.com/wp-content/uploads/2024/06/GARMIN-Venu-Sq-2-Music-Ivory-Peach-Gold-M-BIKE-SHOP-1.jpg",
                        "https://www.univerzalno.com/wp-content/uploads/2024/06/GARMIN-Venu-Sq-2-Music-Ivory-Peach-Gold-M-BIKE-SHOP-6.jpg",
                        "https://www.univerzalno.com/wp-content/uploads/2024/06/garmin-venu-sq-2-music-cream-gold-grey-band_230379_300954.jpg"
                    }
                },
                new Product
                {
                    id = 6,
                    title = "Samsung Galaxy Tab A9",
                    description = "Predstavljen: Oktobar, 2023\r\nEkran: 8.7″, TFT LCD, 800 x 1340px\r\nChipset: Mediatek Helio G99\r\nProcesor: Octa-core (2x 2.2 GHz Cortex-A76 i 6x 2.0 GHz Cortex-A55 jezgre)\r\nGrafika: Mali-G57 MC2\r\nRAM memorija: 4 GB\r\nInterna memorija: 64 GB",
                    price = 310,
                    discountPercentage = 5,
                    rating = 4.85,
                    stock = 17,
                    brand = "Samsung",
                    category = "Tableti",
                    thumbnail = "https://www.univerzalno.com/wp-content/uploads/2023/12/SamsungGalaxyTabA9-1.jpg",
                    images = new List<string>
                    {
                        "https://www.univerzalno.com/wp-content/uploads/2023/12/SamsungGalaxyTabA9-1.jpg",
                        "https://www.univerzalno.com/wp-content/uploads/2023/12/SamsungGalaxyTabA9-2.jpg"
                    }
                },
                new Product
                {
                    id = 7,
                    title = "Laptop Lenovo IP 1",
                    description = "Ekran: 15,6″\r\nProcessor:AMD Ryzen™ 5 5500U,\r\nROM: 512GB SSD M.2 2242 PCIe,\r\nRAM: 12GB RAM",
                    price = 849,
                    discountPercentage = 5,
                    rating = 3.9,
                    stock = 3,
                    brand = "Lenovo",
                    category = "PC/Laptop",
                    thumbnail = "https://www.univerzalno.com/wp-content/uploads/2024/05/82R400FQSC.jpg",
                    images = new List<string>
                    {
                        "https://www.univerzalno.com/wp-content/uploads/2024/05/82R400FQSC.jpg",
                        "https://www.univerzalno.com/wp-content/uploads/2024/05/82R400FQSC-1.jpg",
                        "https://www.univerzalno.com/wp-content/uploads/2024/05/82R400FQSC-2.jpg"
                    }
                },
                new Product
                {
                    id = 8,
                    title = "Samsung Galaxy A55 5G",
                    description = "Poznajte Galaxy A55 5G. Jednostavna, ali poboljšana Galaxy A serija dolazi u kultnom dizajnu s 3 kamere u metalnom ravnom okviru za lako i intuitivno držanje. Pored toga, napravljen je od Corning® Gorilla® Glass Victus®+ što ga čini čvršćim i otpornijim na oštećenja. Dostupan u tri boje Navy, Lilac, Blue.",
                    price = 889,
                    discountPercentage = 15,
                    rating = 3.31,
                    stock = 10,
                    brand = "Samsung",
                    category = "Mobiteli",
                    thumbnail = "https://www.univerzalno.com/wp-content/uploads/2024/06/a55-black-nasl.webp",
                    images = new List<string>
                    {
                        "https://www.univerzalno.com/wp-content/uploads/2024/06/a55-black-nasl.webp",
                    }
                },
                new Product
                {
                    id = 9,
                    title = "Apple iPad Pro",
                    description = "Predstavljen: Oktobar, 2022\r\nEkran: 11″, Liquid Retina IPS LCD, 120Hz, HDR10\r\nChipset: Apple M2\r\nProcesor: Octa-core\r\nGrafika: Apple GPU (10 jezgri)\r\nRAM memorija: 8 GB\r\nInterna memorija: 128 GB",
                    price = 1890,
                    discountPercentage = 10,
                    rating = 4.4,
                    stock = 7,
                    brand = "Apple",
                    category = "Tableti",
                    thumbnail = "https://www.univerzalno.com/wp-content/uploads/2022/11/ipadpro11-2022-1.jpg",
                    images = new List<string>
                    {
                        "https://www.univerzalno.com/wp-content/uploads/2022/11/ipadpro11-2022-1.jpg",
                        "https://www.univerzalno.com/wp-content/uploads/2022/11/ipadpro11-2022-2.jpg"
                    }
                },
                new Product
                {
                    id = 10,
                    title = "Honor Magic5 Lite 5G",
                    description = "Predstavljen: Februar, 2023\r\nEkran: 6.67″, AMOLED, 120Hz, 1080 x 2400px\r\nChipset: Qualcomm SM6375 Snapdragon 695 5G\r\nProcesor: Octa-core (2x 2.2 GHz Kryo 660 Gold i 6x 1.7 GHz Kryo 660 Silver jezgre)\r\nGrafika: Adreno 619\r\nRAM memorija: 6 GB\r\nInterna memorija: 128 GB",
                    price = 550,
                    discountPercentage = 5,
                    rating = 3.94,
                    stock = 3,
                    brand = "Honor",
                    category = "Mobiteli",
                    thumbnail = "https://www.univerzalno.com/wp-content/uploads/2024/01/HonorMagic5Lite-1.jpg",
                    images = new List<string>
                    {
                        "https://www.univerzalno.com/wp-content/uploads/2024/01/HonorMagic5Lite-1.jpg"
                    }
                }
            };

            var productsToShow = category.Equals("Svi uređaji") ? products.ToList() : products.Where(x => x.category.Equals(category)).ToList();

            for (int i = 0; i < productsToShow.Count(); i++)
            {
                Products.Add(productsToShow[i]);
            }
        }
    }
}

