using CSE446_Assignment6.ViewModels;
using CSE446_Assignment6.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CSE446_Assignment6
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
