using ComputerAccessoriesApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ComputerAccessoriesApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ProductRepo repo;
        public MainPage()
        {
            this.InitializeComponent();
            this.repo = new ProductRepo();
            this.listCategories.ItemsSource = this.repo.Categories();
        }
        private void listCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Category c = this.listCategories.SelectedItem as Category;
            this.Frame.Navigate(typeof(ProductList), new RouteParam { categoryId = c.CategoryId });
        }
    }
}
