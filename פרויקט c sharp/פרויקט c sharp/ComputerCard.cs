using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace פרויקט_c_sharp
{
    class ComputerCard
    {
        public int[] arComputer = new int[6];

        public ComputerCard()
        {
            for (int i = 0; i < arComputer.Length; i++)
            {
                arComputer[i] = 0;
            }
        }

        public bool ExistsNum(int num)
        {
            for (int i = 0; i < arComputer.Length; i++)
            {
                if (arComputer[i] == num)
                {
                    return false;
                }
            }
            return true;
        }

        public void GenerateValue()
        {
            Random rnd = new Random();
            int randNum = rnd.Next(1, 47);
            bool isExists;
            isExists = ExistsNum(randNum);
            if(isExists==true)
            {
                for (int i = 0; i < arComputer.Length; i++)
                {
                    randNum = rnd.Next(1, 47);
                    if (arComputer[i] == 0)
                    {
                        isExists = ExistsNum(randNum);
                        arComputer[i] = randNum;
                        Console.WriteLine("Loterry number : {0}", randNum);
                    }
                }
            }
            else
            {
                Console.WriteLine("Number already exists.(Random Number)");
            }
        }
    }
}
