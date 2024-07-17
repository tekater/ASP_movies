using System.Collections.Generic;

namespace ASP_Movie.Cinema
{
	public class Seans
	{
			
            static readonly Movie MovieVenom = 
			new Movie(
				"Venom 5", 
				"Director",
				"Comedy",
                "alien symbiote with an amorphous, liquid-like form, who survives by bonding with a host, usually human");
			static readonly Movie MovieSpider = 
			new Movie(
                "Spider-Man: The destroyer of souls", 
				"Director", 
				"Fantasy",
                "Spider-Man gets his superhuman spider powers and abilities after being bitten by a radioactive spider");
			static readonly Movie MovieJoker = 
			new Movie(
                "Joker: Folie à Deux", 
				"Director", 
				"Triller",
                "Failed comedian Arthur Fleck meets the love of his life, Harley Quinn, while incarcerated at Arkham State Hospita");
			static readonly IDictionary<string, Movie> MovieList = new Dictionary<string, Movie>
			   {
				   {MovieVenom.Name, MovieVenom},
				   {MovieSpider.Name, MovieSpider},
				   {MovieJoker.Name, MovieJoker}
			   };

			public readonly IDictionary<string, List<ShowTime>> SessionList = new Dictionary<string, List<ShowTime>>
			   {
				   {
					MovieVenom.Name, 
					new List<ShowTime>{
						new ShowTime("01.01.2026", "00:00"), 
						new ShowTime("02.02.2026", "00:00")
					}
				},
				   {
					MovieSpider.Name, 
					new List<ShowTime>{
						new ShowTime("25.11.2027", "18:00"), 
						new ShowTime("28.11.2027", "18:00")
					}
				},
				   {
					MovieJoker.Name, 
					new List<ShowTime>{
						new ShowTime("12.12.2025", "10:00"), 
						new ShowTime("15.12.2025", "12:00")
					}
				}
			   };
			public Movie GetMovie(string name)
			{
				MovieList.TryGetValue(name, out Movie movies);
				return movies;
			}
		
	}
}
