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
