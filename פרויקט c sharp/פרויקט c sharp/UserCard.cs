using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace פרויקט_c_sharp
{
    class UserCard
    {
        public int[] arUser = new int[6];

        private string PlayerName;
        public void SetName(string _PlayerName)
        {
            PlayerName = _PlayerName;
        }

        public string GetName()
        {
            return PlayerName;
        }

        //Constructor of UserCard class
        public UserCard()
        {
            for (int i = 0; i < arUser.Length; i++)
            {
                arUser[i] = 0;
            }
            NumbersAlreadyInserted = 0;
        }
        
        //This function will return false if the number exists in the array and true if the number doesnt exists
        public bool ExistsNum(int num)
        {
            for (int i = 0; i < arUser.Length; i++)
            {
                if (arUser[i] == num)
                {
                    return false;
                }    
            }
            return true;
        }

        //Insert a new number in the next available spot in the array
        public void AddNum(int newNum)
        {
            //Once this if equals to 6 numbers no more numbers will be added
            if (NumbersAlreadyInserted==6)
            {
                return;
            }
            bool isExists;
            isExists = ExistsNum(newNum);
            if(isExists==true)
            {
                for (int i = 0; i < arUser.Length; i++)
                {
                    if(arUser[i]==0)
                    {
                        arUser[i] = newNum;
                        NumbersAlreadyInserted++;
                        return;
                    }
                }
            }
        }

        private int NumbersAlreadyInserted;
        public void SetNumber(int _NumbersAlreadyInserted)
        {
            NumbersAlreadyInserted = _NumbersAlreadyInserted;
        }

        public int GetNumber()
        {
            return NumbersAlreadyInserted;
        }
    }
}
