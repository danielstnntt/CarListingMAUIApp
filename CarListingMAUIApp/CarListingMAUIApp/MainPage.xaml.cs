using CarListingMAUIApp.ViewModels;

namespace CarListingMAUIApp
{
    public partial class MainPage : ContentPage
    {
        private readonly CarListViewModel _carListViewModel;

		int count = 0;

        public MainPage(CarListViewModel carListViewModel)
        {
            InitializeComponent();
            BindingContext = carListViewModel;

		}

        
    }

}
