using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task2
{
    class Cinema
    {
        // Private fields that belong to the cinema object

        // _ticket Represent a ticket that will belong to a unique visitor
        private Visitor _visitor;
        private List<Visitor> _visitors;
        private VisitorManager _visitorManager = new VisitorManager();
        private PriceCalculator _priceCalculator = new PriceCalculator();
        

        public Visitor SingleVisitor()
        {
            // Creates and returns a single visitor
            _visitor = _visitorManager.CreateVisitor();
            // Displays price of single visitors ticket.
            _priceCalculator.DisplayTotalPrice(_visitor);
            // Returns the visitor
            return _visitor;
        }

        public List<Visitor> MultipleVisitors()
        {
            _visitors = new List<Visitor>();
            _visitorManager.CreateMultipleVisitors();
            _priceCalculator.DisplayTotalPrice(_visitors);
            return _visitors;
        }
    }
}
