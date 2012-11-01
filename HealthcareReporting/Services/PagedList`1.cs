using System.Collections.Generic;

namespace HealthcareReporting.Services
{
	public class PagedList<T>
		where T : class
	{
		public IEnumerable<T> Items { get; set; }
		public int PageNumber { get; set; }
		public int PageSize { get; set; }
		public bool HasNextPage { get; set; }
		public bool HasPreviousPage { get; set; }
	}
}