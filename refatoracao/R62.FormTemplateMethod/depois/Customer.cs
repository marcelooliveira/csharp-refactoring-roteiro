using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R62.FormTemplateMethod.depois
{
    class Customer
    {
        public Customer()
        {
            var statement = new Statement(this).GetStatement();
            var htmlStatement = new HTMLStatement(this).GetStatement();
        }

        private IList<Rental> rentals;
        public IList<Rental> Rentals
        {
            get { return rentals; }
            set { rentals = value; }
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

    abstract class BaseStatement
    {
        protected readonly Customer customer;

        public BaseStatement(Customer customer)
        {
            this.customer = customer;
        }

        public string GetStatement()
        {
            var result = new StringBuilder();
            result.AppendLine(GetTitle());
            foreach (var rental in customer.Rentals)
            {
                result.AppendLine(GetRentalDetail(rental));
            }
            result.AppendLine(GetAmountOwedText());
            result.AppendLine(GetAmountEarnedText());
            return result.ToString();
        }

        protected abstract string GetAmountEarnedText();

        protected abstract string GetAmountOwedText();

        protected abstract string GetRentalDetail(Rental rental);

        protected abstract string GetTitle();
    }

    class Statement : BaseStatement
    {
        public Statement(Customer customer) : base(customer)
        {
        }

        protected override string GetAmountEarnedText()
        {
            return "You earned " + customer.TotalFrequentRenderPoints.ToString();
        }

        protected override string GetAmountOwedText()
        {
            return "Amount owed is " + customer.TotalCharge.ToString();
        }

        protected override string GetRentalDetail(Rental rental)
        {
            return "\t" + rental.Movie.Title;
        }

        protected override string GetTitle()
        {
            return "Rental Record for " + customer.Name;
        }
    }

    class HTMLStatement : BaseStatement
    {
        public HTMLStatement(Customer customer) : base(customer)
        {
        }

        protected override string GetAmountEarnedText()
        {
            return "You earned <em>" + customer.TotalFrequentRenderPoints.ToString() + "</em> frequent renter points.";
        }

        protected override string GetAmountOwedText()
        {
            return "<p> You owe <em>" + customer.TotalCharge.ToString() + "</em></p>";
        }

        protected override string GetRentalDetail(Rental rental)
        {
            return rental.Movie.Title + "<br/>";
        }

        protected override string GetTitle()
        {
            return "<h1>Rentals for <em>" + customer.Name + "</em></h1>";
        }
    }
}
