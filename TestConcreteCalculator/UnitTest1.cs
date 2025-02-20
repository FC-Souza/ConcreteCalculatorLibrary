using ConcreteCalculatorLibrary;
using NUnit.Framework;


namespace TestConcreteCalculator
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateCost_NewResidentialZeroSquarMeters_CostZero()
        {
            //Arrange
            var customerType = CustomerType.NewResidential;
            double squareMeters = 0;

            //Act
            double cost = ConcreteCostCalculator.CalculateCost(customerType, squareMeters);

            //Assert
            Assert.That(cost, Is.EqualTo(0));
        }

        [Test]
        public void CalculateCost_NewResidentialOneSquarMeters_Cost30()
        {
            //Arrange
            var customerType = CustomerType.NewResidential;
            double squareMeters = 1;

            //Act
            double cost = ConcreteCostCalculator.CalculateCost(customerType, squareMeters);

            //Assert
            Assert.That(cost, Is.EqualTo(30));
        }


        [Test]
        public void CalculateCost_NewResidentialTwoSquarMeters_Cost60()
        {
            //Arrange
            var customerType = CustomerType.NewResidential;
            double squareMeters = 2;

            //Act
            double cost = ConcreteCostCalculator.CalculateCost(customerType, squareMeters);

            //Assert
            Assert.That(cost, Is.EqualTo(60));
        }




        [Test]
        public void CalculateCost_ExistingResidentialZeroSquarMeters_CostZero()
        {
            //Arrange
            var customerType = CustomerType.ExistingResidential;
            double squareMeters = 0;

            //Act
            double cost = ConcreteCostCalculator.CalculateCost(customerType, squareMeters);

            //Assert
            Assert.That(cost, Is.EqualTo(0));
        }

        [Test]
        public void CalculateCost_ExistingResidentialOneSquarMeters_Cost25()
        {
            //Arrange
            var customerType = CustomerType.ExistingResidential;
            double squareMeters = 1;

            //Act
            double cost = ConcreteCostCalculator.CalculateCost(customerType, squareMeters);

            //Assert
            Assert.That(cost, Is.EqualTo(25));
        }


        [Test]
        public void CalculateCost_ExistingResidentialTwoSquarMeters_Cost50()
        {
            //Arrange
            var customerType = CustomerType.ExistingResidential;
            double squareMeters = 2;

            //Act
            double cost = ConcreteCostCalculator.CalculateCost(customerType, squareMeters);

            //Assert
            Assert.That(cost, Is.EqualTo(50));
        }


        [Test]
        public void CalculateCost_CommercialZeroSquarMeters_CostZero()
        {
            //Arrange
            var customerType = CustomerType.Commercial;
            double squareMeters = 0;

            //Act
            double cost = ConcreteCostCalculator.CalculateCost(customerType, squareMeters);

            //Assert
            Assert.That(cost, Is.EqualTo(0));
        }

        [Test]
        public void CalculateCost_CommercialOneSquarMeters_Cost20()
        {
            //Arrange
            var customerType = CustomerType.Commercial;
            double squareMeters = 1;

            //Act
            double cost = ConcreteCostCalculator.CalculateCost(customerType, squareMeters);

            //Assert
            Assert.That(cost, Is.EqualTo(20));
        }


        [Test]
        public void CalculateCost_CommercialTwoSquarMeters_Cost40()
        {
            //Arrange
            var customerType = CustomerType.Commercial;
            double squareMeters = 2;

            //Act
            double cost = ConcreteCostCalculator.CalculateCost(customerType, squareMeters);

            //Assert
            Assert.That(cost, Is.EqualTo(40));
        }




    }

}