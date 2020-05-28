using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building Building1 = new Building("512 8th Avenue");
            Building1.Width = 20.5;
            Building1.Depth = 15.8;
            Building1.Stories = 5;
            Building1.Construct();
            Building1.Purchase("Tom Richman");
            Building1.BuildingInfo();

            Building Building2 = new Building("411 9th Avenue");
            Building2.Width = 25.5;
            Building2.Depth = 14.8;
            Building2.Stories = 6;
            Building2.Construct();
            Building2.Purchase("Rich Rick");
            Building2.BuildingInfo();

            Building Building3 = new Building("310 10th Avenue");
            Building3.Width = 30.5;
            Building3.Depth = 13.8;
            Building3.Stories = 7;
            Building3.Construct();
            Building3.Purchase("Richelle Rich");
            Building3.BuildingInfo();

            Building Building4 = new Building("219 11th Avenue");
            Building4.Width = 35.5;
            Building4.Depth = 12.8;
            Building4.Stories = 8;
            Building4.Construct();
            Building4.Purchase("Loaded Guyferson");
            Building4.BuildingInfo();

            Building Building5 = new Building("118 12th Avenue");
            Building5.Width = 40.5;
            Building5.Depth = 11.8;
            Building5.Stories = 9;
            Building5.Construct();
            Building5.Purchase("John D. Rockefeller");
            Building5.BuildingInfo();


        }
    }
}
