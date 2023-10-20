using System;

namespace DeveloperSample.ClassRefactoring
{
    public enum SwallowType
    {
        African, European
    }

    public enum SwallowLoad
    {
        None, Coconut
    }

    public class SwallowFactory
    {
        public Swallow GetSwallow(SwallowType swallowType)
        {
            switch (swallowType)
            {
                case SwallowType.African:
                    return new AfricanSwallow();
                case SwallowType.European:
                    return new EuropeanSwallow();
                default:
                    throw new ArgumentException("Invalid SwallowType");
            }
        }
    }

    public abstract class Swallow
    {
        public SwallowType Type { get; protected set; }
        public SwallowLoad Load { get; private set; }

      

        public void ApplyLoad(SwallowLoad load)
        {
            Load = load;
        }

        public abstract double GetAirspeedVelocity();

     
    }

    public class AfricanSwallow : Swallow
    {
        
        public AfricanSwallow()
        {
            Type = SwallowType.African;
        }

        public override double GetAirspeedVelocity()
        {
            return Load == SwallowLoad.None ? 22 : 18;
        }
    }

    public class EuropeanSwallow : Swallow
    {

       
        public EuropeanSwallow()
        {
            Type = SwallowType.European;
        }


        public override double GetAirspeedVelocity()
        {
            return Load == SwallowLoad.None ? 20 : 16;
        }
    }

   
}