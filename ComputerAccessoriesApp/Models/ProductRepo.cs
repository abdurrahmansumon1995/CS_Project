using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerAccessoriesApp.Models
{
    public class ProductRepo
    {
        ObservableCollection<Category> categories;
        ObservableCollection<Product> products;
        public ProductRepo()
        {
            this.categories = new ObservableCollection<Category>()
            {
                new Category { CategoryId=1, Name="Storage Device", Picture="Assets/storage.png"},
                new Category { CategoryId=2, Name="Memory Modules", Picture="Assets/memory.png"},
                new Category { CategoryId=3, Name="Motherboard", Picture="Assets/motherboard.png"},
                new Category { CategoryId=4, Name="Key Board", Picture="Assets/keyboard.png"},
                new Category { CategoryId=5, Name="Mouse", Picture="Assets/mouse.png"},
                new Category { CategoryId=6, Name="printer", Picture="Assets/printer.png"},
                new Category { CategoryId=7, Name="Sound Devices", Picture="Assets/sound.png"}

            };
            this.products = new ObservableCollection<Product>()
            {
                new Product{ ProductId=1, CategoryId=1, Name="Hitachi 1TB", Price=3800.00M, ManufactureDate=DateTime.Now.AddDays(-310) },
                new Product{ ProductId=2, CategoryId=1, Name="Seagate Baracuda 2TB", Price=9000.00M, ManufactureDate=DateTime.Now.AddDays(-210) },
                new Product{ ProductId=3, CategoryId=1, Name="Wetern Digital 1TB", Price=3800.00M, ManufactureDate=DateTime.Now.AddDays(-220) },
                new Product{ ProductId=4, CategoryId=1, Name="Toshiba 1TB", Price=3700.00M, ManufactureDate=DateTime.Now.AddDays(-222) },
                new Product{ ProductId=5, CategoryId=1, Name="Samsung EVO SSD 1TB", Price=17000.00M, ManufactureDate=DateTime.Now.AddDays(-300) },

                new Product{ ProductId=6, CategoryId=2, Name="Hynix 8GB", Price=6000.00M, ManufactureDate=DateTime.Now.AddDays(-110) },
                new Product{ ProductId=7, CategoryId=2, Name="Transcend 8GB", Price=6000.00M, ManufactureDate=DateTime.Now.AddDays(-50) },
                new Product{ ProductId=8, CategoryId=2, Name="Team 8GB", Price=6000.00M, ManufactureDate=DateTime.Now.AddDays(-60) },
                new Product{ ProductId=9, CategoryId=2, Name="Silicon Power 8GB", Price=6000.00M, ManufactureDate=DateTime.Now.AddDays(-70) },

                new Product{ ProductId=10, CategoryId=3, Name="ASRock A320M-HDV R4.0 AMD", Price=5900.00M, ManufactureDate=DateTime.Now.AddDays(-110) },
                new Product{ ProductId=11, CategoryId=3, Name="Asus Prime A320M-K AMD AM4 uATX", Price=6400.00M, ManufactureDate=DateTime.Now.AddDays(-200) },
                new Product{ ProductId=12, CategoryId=3, Name="Gigabyte H310M S2P 8th Gen Micro ATX", Price=6000.00M, ManufactureDate=DateTime.Now.AddDays(-120) },

                new Product{ ProductId=13, CategoryId=4, Name="Walton WKS005WN USB", Price=6000.00M, ManufactureDate=DateTime.Now.AddDays(-250) },
                new Product{ ProductId=14, CategoryId=4, Name="IMICE GK-480", Price=2365.00M, ManufactureDate=DateTime.Now.AddDays(-90) },
                new Product{ ProductId=15, CategoryId=4, Name="MotoSpeed S102", Price=695.00M, ManufactureDate=DateTime.Now.AddDays(-120) },

                new Product{ ProductId=16, CategoryId=5, Name="Motospeed V70 3360", Price=1500.00M, ManufactureDate=DateTime.Now.AddDays(-420) },
                new Product{ ProductId=17, CategoryId=5, Name="A4TECH FG1112", Price=1560.00M, ManufactureDate=DateTime.Now.AddDays(-230) },

                new Product{ ProductId=18, CategoryId=6, Name="HP LaserJet 107a", Price=13500.00M, ManufactureDate=DateTime.Now.AddDays(-140) },
                new Product{ ProductId=19, CategoryId=6, Name="Epson PictureMate PM-520", Price=21500.00M, ManufactureDate=DateTime.Now.AddDays(-120) },
                new Product{ ProductId=20, CategoryId=6, Name="Canon Pixma G2010", Price=21300.00M, ManufactureDate=DateTime.Now.AddDays(-10) },

                new Product{ ProductId=21, CategoryId=7, Name="Rapoo A100", Price=1650.00M, ManufactureDate=DateTime.Now.AddDays(-130) },
                new Product{ ProductId=22, CategoryId=7, Name="F&D F3000X 5:1r", Price=7900.00M, ManufactureDate=DateTime.Now.AddDays(-140) },
                new Product{ ProductId=23, CategoryId=7, Name="Microlab SOLO 9C", Price=19000.00M, ManufactureDate=DateTime.Now.AddDays(-170) },
                new Product{ ProductId=24, CategoryId=7, Name="F&D F770X 2:1", Price=9650.00M, ManufactureDate=DateTime.Now.AddDays(-160) }
                
            };
        }
        public ObservableCollection<Category> Categories() { return this.categories; }
        public ObservableCollection<Product> Products() { return this.products; }
        public IEnumerable<Product> Products(int categoryId)
        {
            return this.products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
