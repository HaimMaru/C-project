using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace פרויקט_c_sharp
{
    class CheckPlay
    {
        UserCard user1;
        ComputerCard computer1;
        public CheckPlay(UserCard tmpUC,ComputerCard tmpCC)
        {
            user1 = tmpUC;
            computer1 = tmpCC;
        }

        public int Compare()
        {
            int counter=0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if(user1.arUser[i]==computer1.arComputer[j])
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
