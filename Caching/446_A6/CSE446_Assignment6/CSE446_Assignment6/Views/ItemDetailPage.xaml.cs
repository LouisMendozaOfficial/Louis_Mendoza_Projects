using CSE446_Assignment6.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CSE446_Assignment6.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}