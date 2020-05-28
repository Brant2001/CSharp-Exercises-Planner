using System;

namespace Planner
{
    // Define class here
    public class Building
    {
        /*
            Private Fields
        */
        private string _designer = "Brant Pippin";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        /*
            Public Properties
        */
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return 3 * Stories * Width * Depth;
            }

        }

        /*
            Constructor Methods
        */
        public Building(string address)
        {
            _address = address;
        }

        /*
            Public Methods
        */
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string owner)
        {
            _owner = owner;
        }

        public void BuildingInfo()
        {
            Console.WriteLine();
            Console.WriteLine(_address);
            Console.WriteLine("-----------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume}, cubic meters of space.");
            Console.WriteLine();
        }
    }
}