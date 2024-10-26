


using tyuiu.cources.programming.interfaces.Sprint3;



namespace Tyuiu.BurdovKS.Sprint3.Task1.V1.Lib
{
    public class DataService : ISprint3Task1V1
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double i = 1;

            while (startValue <= stopValue)
            {

                double pp = startValue;
    
                double gg = 3 / pp;
                i = i * Math.Pow(gg, -2);
                startValue++;
            }
            return Math.Round(i, 3);

      
           
        }
    }
}
