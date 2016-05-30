using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using teamnotfound.Common;
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

namespace teamnotfound.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MyPost : Page
    {
        public MyPost()
        {
            this.InitializeComponent();
        }

        private IMobileServiceTable<Project> projectTable = App.MobileService.GetTable<Project>();
        private MobileServiceCollection<Project, Project> items;
        string parameter;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            parameter = e.Parameter as string;
            //Debug.Write("param1: " + parameter);
            getProjects(parameter);
        }

        private async void getProjects(String parameter)
        {


            items = await projectTable
                    .Where(Project => Project.Owner == Global.GetRepositoryValue("userName").ToString())
                    .ToCollectionAsync();
            gridView.ItemsSource = items;
        }

        private void gridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Debug.Write(" in item clicked ");
            Debug.Write(e.ToString());
        }

        private void StackPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Debug.Write(" in item tabed "+ e.ToString());
        }
    }
}
