using System.ComponentModel;
using Xamarin.Forms;
using CarouselAppDem.ViewModels;

namespace CarouselAppDem.Views
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