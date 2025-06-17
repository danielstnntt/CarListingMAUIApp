using CarListingMAUIApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListingMAUIApp.Services
{
	public class CarService
	{

		private List<Car> _cars = new List<Car>
		{
			new Car { Id = 1, Make = "Mitsubishi", Model = "Mirage", VIN = "1HGBH41JXMN109186" },
			new Car { Id = 2, Make = "VW", Model = "Golf", VIN = "1HGBH41JXMN109187" },
			new Car { Id = 3, Make = "Citeron", Model = "Saxo", VIN = "1HGBH41JXMN109188" },
			new Car { Id = 4, Make = "Honda", Model = "Civic", VIN = "1HGBH41JXMN109189" },
			new Car { Id = 5, Make = "Nissan", Model = "Qashqai", VIN = "1HGBH41JXMN109190" },
			new Car { Id = 6, Make = "Vauxhall", Model = "Corsa", VIN = "1HGBH41JXMN109191" }
		};
		public List<Car> GetCars()
		{
			return _cars;
		}
	}
}
