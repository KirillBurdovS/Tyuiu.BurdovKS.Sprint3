



using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.BurdovKS.Sprint3.Task3.V22.Lib
{
    public class DataService : ISprint3Task3V22
    {
        public int GetMaxCharCount(string value, char item)
        {

            int count = 0;

            foreach (char ch in value)
            {
                if(ch == item)
                {
                    count++;
                }
               
            }
            return count;





        }
    }
}
