using System;

namespace ConcreteCalculatorLibrary
{
    public enum CustomerType
    {
        NewResidential,
        ExistingResidential,
        Commercial
    }

    public class ConcreteCostCalculator
    {
        public static double CalculateCost(CustomerType customerType, double squareMeters)
        {
            double rate = GetRate(customerType);
            return squareMeters * rate;
        }

        private static double GetRate(CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.NewResidential:
                    return 30;
                case CustomerType.ExistingResidential:
                    return 25;
                case CustomerType.Commercial:
                    return 20;
                default:
                    throw new ArgumentException("Invalid customer type");
            }
        }
    }
}













/*
Open Visual Studio

create a class library

Add a new project
	NUnit 3 Test Project
	
Install the nuget package
	NUnit
	NUnit.Analyzers
	NUnit3TestAdapter
	
Test Project
	Right Click > Add > Project Reference
		Select the class library > OK

Save the Solution

Test > Run all Tests

Test > Test Explorer

*/



