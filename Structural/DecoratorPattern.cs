using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Structural
{
    // Decorator Pattern allows behavior to be added to an individual object, dynamically,
    // without affecting the behavior of other objects from the same class.
    internal class DecoratorPattern
    {
        // Component
        public interface ICar
        {
            string GetDescription();
            double GetCost();
        }

        // Concrete Component
        public class BasicCar : ICar
        {
            public string GetDescription() => "Basic Car";
            public double GetCost() => 20000;
        }

        // Decorator
        public abstract class CarDecorator : ICar
        {
            protected readonly ICar _car;
            protected CarDecorator(ICar car)
            {
                _car = car;
            }
            public virtual string GetDescription() => _car.GetDescription();
            public virtual double GetCost() => _car.GetCost();
        }

        // Concrete Decorators
        public class SunroofDecorator : CarDecorator
        {
            public SunroofDecorator(ICar car) : base(car) { }
            public override string GetDescription() => $"{_car.GetDescription()}, Sunroof";
            public override double GetCost() => _car.GetCost() + 1500;
        }

        public class LeatherSeatsDecorator : CarDecorator
        {
            public LeatherSeatsDecorator(ICar car) : base(car) { }
            public override string GetDescription() => $"{_car.GetDescription()}, Leather Seats";
            public override double GetCost() => _car.GetCost() + 2000;
        }
                
        
    }
}
