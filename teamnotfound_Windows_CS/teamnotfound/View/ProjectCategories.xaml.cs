using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using teamnotfound.DataModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace teamnotfound
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProjectCategories : Page
    {
        private IMobileServiceTable<Category> categoryTable = App.MobileService.GetTable<Category>();
        private MobileServiceCollection<Category, Category> items;
        private IMobileServiceTable<Project> projectTable = App.MobileService.GetTable<Project>();
        private MobileServiceCollection<Project, Project> projects;
        public ProjectCategories()
        {
            this.InitializeComponent();
            getCategories();
        }
        private async void getCategories()
        {
            items = await categoryTable
                    .ToCollectionAsync();
            List<Category> proj = new List<Category>();
            proj = items.ToList();
            for (var i = 0; i < proj.Count; i++)
            {
                getCount(proj[i].Name);
            }
            CategoryGridView.ItemsSource = items;
        }
        private async void getCount(string cat)
        {
            items = await categoryTable
                .Where(Category => Category.Name == cat)
                    .ToCollectionAsync();

            List<Category> category = new List<Category>();
            category = items.ToList();
            String categoryId = category[0].Id;
            //Debug.Write("Id: " + proj[0].CatId);

            projects = await projectTable
                .Where(Project => Project.Type == categoryId)
                    .ToCollectionAsync();

            List<Project> proj = new List<Project>();
            proj = projects.ToList();
            Debug.Write(proj.Count);
            //CategoryGridView.ItemTemplate.LoadContent
           



        }
        private void Category_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string text=((sender as StackPanel).FindName("categoryName") as TextBlock).Text;
            Debug.Write("Text: " + text);
            //search.Text = text;
            Frame.Navigate(typeof(SearchProject),text);
        }
    }
}
