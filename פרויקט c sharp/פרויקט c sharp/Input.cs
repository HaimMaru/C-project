using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace פרויקט_c_sharp
{
    class Input
    {
        UserCard uc;
        int[] arInput = new int[6];
        public Input()
        {
            for (int i = 0; i < arInput.Length; i++)
            {
                arInput[i] = 0;
            }
            uc = new UserCard();
        }

        public UserCard GetUserCard()
        {
            return uc;
        }

        public void GetUserValues()
        {
            bool isInsert;
            int numToInsert;
            int counter = 1;
            while(counter<=6)
            {
                Console.WriteLine("Please enter an integer: ");
                string str = Console.ReadLine();
                int.TryParse(str, out numToInsert);
                if(numToInsert<=0 || numToInsert>46)
                {
                    Console.WriteLine("Number is not in range.");
                    continue;
                }
                isInsert = uc.ExistsNum(numToInsert);
                if(isInsert==true)
                {
                    uc.AddNum(numToInsert);
                    counter++;
                }
                else
                {
                    Console.WriteLine("The number already exists.(UserCard)");
                }
            }
        }
    }
}
