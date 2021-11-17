using MissingMethodExceptionSample.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MissingMethodExceptionSample.Views
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