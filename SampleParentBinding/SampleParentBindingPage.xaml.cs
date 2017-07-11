using SampleParentBinding.ViewModels;
using Xamarin.Forms;

namespace SampleParentBinding
{
    public partial class SampleParentBindingPage : ContentPage
    {
        public SampleParentBindingPage()
        {
            InitializeComponent();

            BindingContext = new ParkingListViewModel();
        }

        void OnMoreClicked(object sender, System.EventArgs args)
        {
            DisplayAlert("TADA", "Click action here", "OKIDOKI!");
        }
    }
}