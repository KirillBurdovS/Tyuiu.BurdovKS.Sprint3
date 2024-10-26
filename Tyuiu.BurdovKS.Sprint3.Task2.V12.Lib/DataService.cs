


using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.BurdovKS.Sprint3.Task2.V12.Lib
{
    public class DataService : ISprint3Task2V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {


            double gg;

            double wp;

            double p = 1;

            do
            {

                double m1 = startValue;

                gg = m1 + Math.Pow(value, m1);

                wp = 300 / gg;
                
                p *= Math.Pow(wp, m1);
                startValue++;

            }
            while(startValue <= stopValue);

            return Math.Round(p, 3);
        }
        
    }
}
