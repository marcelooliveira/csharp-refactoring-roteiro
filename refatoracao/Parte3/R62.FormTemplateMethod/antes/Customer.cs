using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R62.FormTemplateMethod.antes
{
    class Customer
    {
        public Customer()
        {
            var statement = GetStatement();
            var htmlStatement = GetHTMLStatement();
        }

        public string GetStatement()
        {
            var result = new StringBuilder();
            result.AppendLine("Rental Record for " + Name);
            foreach (var rental in Rentals)
            {
                result.AppendLine("\t" + rental.Movie.Title);
            }
            result.AppendLine("Amount owed is " + TotalCharge.ToString());
            result.AppendLine("You earned " + TotalFrequentRenderPoints.ToString());
            return result.ToString();
        }

        public string GetHTMLStatement()
        {
            var result = new StringBuilder();
            result.AppendLine("<h1>Rentals for <em>" + Name + "</em></h1>");
            foreach (var rental in Rentals)
            {
                result.AppendLine(rental.Movie.Title + "<br/>");
            }
            result.AppendLine("<p> You owe <em>" + TotalCharge.ToString() + "</em></p>");
            result.AppendLine("You earned " + TotalFrequentRenderPoints.ToString() + "</em> frequent renter points.");
            return result.ToString();
        }

        private IList<Rental> rental;
        public IList<Rental> Rentals
        {
            get { return rental; }
            set { rental = value; }
        }

        private double totalCharge;
        public double TotalCharge
        {
            get { return totalCharge; }
            set { totalCharge = value; }
        }

        private double totalFrequentRenderPoints;
        public double TotalFrequentRenderPoints
        {
            get { return totalFrequentRenderPoints; }
            set { totalFrequentRenderPoints = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Rental
    {
        private Movie movie;

        public Movie Movie
        {
            get { return movie; }
            set { movie = value; }
        }
    }

    class Movie
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
    }
}
