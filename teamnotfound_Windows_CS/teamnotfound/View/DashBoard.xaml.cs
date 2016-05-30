﻿using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using teamnotfound;
using teamnotfound.Common;
using teamnotfound.View;
using TeamNotFound.Models;
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

namespace TeamNotFound.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DashBoard : Page
    {
        private User user = new User();

        public DashBoard()
        {
            this.InitializeComponent();
            
            myFrame.Navigate(typeof(Profile));

        }
      
        
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void PostProject_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = false;
            myFrame.Navigate(typeof(PostProject));
        }
        private void MyProject_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = false;
            myFrame.Navigate(typeof(MyPost));
        }
        private void Profile_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = false;
            //Load the custom page
            myFrame.Navigate(typeof(Profile));
        }
    }
}
