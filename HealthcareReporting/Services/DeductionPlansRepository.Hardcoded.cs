﻿using System.Collections.Generic;

namespace HealthcareReporting.Services
{
	internal static class DeductionPlansRepositoryHardcoded
	{
		internal static IEnumerable<Deduction> Deductions
		{
			get
			{
				return new List<Deduction> {
					new Deduction {Id = 1, Name = "MEDICAL PRE-TAX"},
					new Deduction {Id = 2, Name = "DENTAL PRE-TAX"},
					new Deduction {Id = 3, Name = "VISION PRE-TAX"},
					new Deduction {Id = 4, Name = "PARKING"},
					new Deduction {Id = 5, Name = "SHOPPING"},
					new Deduction {Id = 6, Name = "MEAL TICKETS"},
				};
			}
		}
	}
}