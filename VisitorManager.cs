using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task2
{
    // Handles the creation and management of visitors
    class VisitorManager
    {
        private VisitorInput _visitorInput = new VisitorInput();

        // Handle the creation of a single visitor
        public Visitor CreateVisitor()
        {
            Messages.GreetVisitor();
            return new Visitor(_visitorInput.SingleVisitorAge());
            
        }

        // Handle the creation of multiple visitors
        public List<Visitor> CreateMultipleVisitors()
        {
            Messages.GreetVisitor();
            int numberOfVisitors = _visitorInput.GetNumberOfVisitors();

            return _visitorInput.GetAgesForMultipleVisitors(numberOfVisitors)
                .Select(age => new Visitor(age))
                .ToList();
        }
    }
}
