<Query Kind="Statements" />

var books = new[] {
		new { Author = "Robert Martin", Title = "Clean Code", Pages = 464 },
		new { Author = "Oliver Sturm", Title = "Functional Programming in C#" , Pages = 270 },
		new { Author = "Martin Fowler", Title = "Patterns of Enterprise Application Architecture", Pages = 533 },
        new { Author = "Bill Wagner", Title = "Effective C#", Pages = 328 },
		};


books.Max(b => b.Pages).Dump("Max pages");

books.First(b => b.Pages == books.Max(x => x.Pages)).Dump("Bad performance!");

var mostPages = books.Max(x => x.Pages);
books.First(b => b.Pages == mostPages).Dump("Better performance!");

books.OrderByDescending(b => b.Pages).First().Dump("Hmmm! N^2 complexity performance");

books.Aggregate((agg, next) => next.Pages > agg.Pages ? next : agg).Dump("Good, lineair performance");