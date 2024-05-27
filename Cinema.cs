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
            _visitor = _visitorManager.CreateVisitor();
            _priceCalculator.DisplayTotalPrice(_visitor);
            return _visitor;
        }

        public List<Visitor> MultipleVisitors()
        {
            _visitors = _visitorManager.CreateMultipleVisitors();
            _priceCalculator.DisplayTotalPrice(_visitors);
            return _visitors;
        }
    }
}
