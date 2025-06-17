using CarListingMAUIApp.Models;
using CarListingMAUIApp.Services;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListingMAUIApp.ViewModels
{
	public partial class CarListViewModel : BaseViewModel
	{
		public readonly CarService carService;
		public ObservableCollection<Car> Cars { get; private set; }

		public CarListViewModel(CarService carService) 
		{
			Title = "Car List";
			this.carService = carService;
		}

		[RelayCommand]
		async Task GetCarList()
		{

			if (IsLoading)	
				return;
			try
			{
				IsLoading = true;
				if (Cars.Any())
				{
					Cars.Clear();
				}
				else
				{
					var cars = carService.GetCars();
					foreach (Car car in cars)
					{
						Cars.Add(car);
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine($"Error - Unable In GetCarList functions: {ex.Message}");
				await Shell.Current.DisplayAlert($"Error", "Failed to Retrieve List of Cars", "OK");
			}
			finally
			{
				IsLoading = false;
			}
		}

	}
}
