﻿using DesignPatternsDemo.Decorator.Interface;

namespace DesignPatternsDemo.Decorator.Classes
{
    public abstract class CarDecorator : ICar
    {
        protected ICar _car;

        public CarDecorator(ICar car)
        {
            _car = car;
        }

        public virtual string GetDescription()
        {
            return _car.GetDescription();
        }

        public virtual double GetCost()
        {
            return _car.GetCost();
        }
    }

}
