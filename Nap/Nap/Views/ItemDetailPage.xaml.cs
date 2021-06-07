using Nap.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Nap.Views
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