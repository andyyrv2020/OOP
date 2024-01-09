using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWorkerManagement
{
	class Worker : Human
	{
		public decimal HourlyWage { get; set; }
		public int WorkedHours { get; set; }

		public Worker(string firstName, string lastName, decimal hourlyWage, int workedHours)
			: base(firstName, lastName)
		{
			HourlyWage = hourlyWage;
			WorkedHours = workedHours;
		}

		public decimal CalculateHourlyEarnings()
		{
			return HourlyWage * WorkedHours;
		}
	}
}
