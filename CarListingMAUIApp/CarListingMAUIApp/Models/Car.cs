using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListingMAUIApp.Models
{
	public class Car : BaseEntity
	{
		public string Make { get; set; }
		public string Model { get; set; }
		//VIN means Vehicle Identification Number
		public string VIN { get; set; } 

	}
}
