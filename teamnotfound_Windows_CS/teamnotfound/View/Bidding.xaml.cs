using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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
    public sealed partial class Bidding : Page
    {
        private IMobileServiceTable<Project> projectTable = App.MobileService.GetTable<Project>();
        private MobileServiceCollection<Project, Project> items;
        private IMobileServiceTable<Bid> bidTable = App.MobileService.GetTable<Bid>();
        List<Project> proj = new List<Project>();
        string parameter;
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            parameter = e.Parameter as string;
            //Debug.Write("param1: " + parameter);
            getProjects(parameter);
        }
        public Bidding()
        {
            this.InitializeComponent();
        }
        private async void getProjects(string parameter)
        {
            items = await projectTable
                    .Where(Project => Project.Id == parameter)
                    .ToCollectionAsync();
            proj = items.ToList();
            txtDesc.Text = proj[0].Description;
            txtBid.Text = (proj[0].Bid).ToString();
            //gridView.ItemsSource = items;
        }

        private async void button_Click (object sender, RoutedEventArgs e)
        {
            var bid = new Bid { BiddAmt = Int32.Parse(txtAmount.Text), TimePeriod= Int32.Parse(txtTime.Text),Bidder ="diksha.bajaj@hpe.com", ProjectId = proj[0].Id };
            await InsertBid(bid);
            Frame.Navigate(typeof(MyProjects));
           
        }
        private async Task InsertBid(Bid bid)
        {
            // This code inserts a new TodoItem into the database. When the operation completes
            // and Mobile Apps has assigned an Id, the item is added to the CollectionView
            await bidTable.InsertAsync(bid);


            //await App.MobileService.SyncContext.PushAsync(); // offline sync
        }
       /* private async Task UpdateProject(Project project)
        {
            // This code inserts a new TodoItem into the database. When the operation completes
            // and Mobile Apps has assigned an Id, the item is added to the CollectionView
           items = await projectTable
                            .Where(Project => Project.Id == project.Id)
                            .ToCollectionAsync();
            Project proj = items.FirstOrDefault();
            await projectTable.UpdateAsync(proj);
        }*/
    }
}
