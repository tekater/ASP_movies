using System.Collections.Generic;

namespace ASP_Movie.Cinema
{
	public class ShowTime
	{
		public string Date { get; }
		public string Time { get; }

		public ShowTime(string date, string time)
		{
			Date = date;
			Time = time;
		}
        public List<ShowTime> Showtimes { get; set; }
    }
}
