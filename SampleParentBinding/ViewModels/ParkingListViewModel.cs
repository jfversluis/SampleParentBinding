using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using SampleParentBinding.Models;
using Xamarin.Forms;

namespace SampleParentBinding.ViewModels
{
    public class ParkingListViewModel
    {
        public Command AddToFavoriteCommand { get; }

        public ObservableCollection<CustomPin> CustomPins { get; set; } = new ObservableCollection<CustomPin>()
        {
			new CustomPin{ Street = "Spiderman street"},
			new CustomPin{ Street = "Iron Man lane"},
			new CustomPin{ Street = "Thor way"},
			new CustomPin{ Street = "Captain America square"}, 
        };

        public ParkingListViewModel()
        {
            AddToFavoriteCommand = new Command(Test);
        }

        private void Test()
        {
            Debug.WriteLine("Command executed!");
        }
    }
}