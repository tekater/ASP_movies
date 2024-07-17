using System.Collections.Generic;

namespace ASP_Movie.Cinema
{
	public class Seans
	{
		public List<Movie> _films;
			
            static readonly Movie Movie1 = 
			new Movie(
				"Venom 5", 
				"Director",
				"Comedy",
                "alien symbiote with an amorphous, liquid-like form, who survives by bonding with a host, usually human");
			static readonly Movie Movie2 = 
			new Movie(
                "Spider-Man: The destroyer of souls", 
				"Director", 
				"Fantasy",
                "Spider-Man gets his superhuman spider powers and abilities after being bitten by a radioactive spider");
			static readonly Movie Movie3 = 
			new Movie(
                "Joker: Folie à Deux", 
				"Director", 
				"Triller",
                "Failed comedian Arthur Fleck meets the love of his life, Harley Quinn, while incarcerated at Arkham State Hospita");
			static readonly IDictionary<string, Movie> MovieList = new Dictionary<string, Movie>
			   {
				   {Movie1.Name, Movie1},
				   {Movie2.Name, Movie2},
				   {Movie3.Name, Movie3}
			   };

			public readonly IDictionary<string, List<ShowTime>> SessionList = new Dictionary<string, List<ShowTime>>
			   {
				   {
					Movie1.Name, 
					new List<ShowTime>{
						new ShowTime("01.01.2026", "00:00"), 
						new ShowTime("02.02.2026", "00:00")
					}
				},
				   {
					Movie2.Name, 
					new List<ShowTime>{
						new ShowTime("25.11.2027", "18:00"), 
						new ShowTime("28.11.2027", "18:00")
					}
				},
				   {
					Movie3.Name, 
					new List<ShowTime>{
						new ShowTime("12.12.2025", "10:00"), 
						new ShowTime("15.12.2025", "12:00")
					}
				}
			   };
			public Movie GetMovie(string name)
			{
				MovieList.TryGetValue(name, out Movie movie);
				return movie;
			}
		
	}
}
