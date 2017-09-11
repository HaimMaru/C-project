using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace פרויקט_c_sharp
{
    class Game
    {
        ComputerCard c1;
        Input i1;
        CheckPlay cp;
        Output o1;
        public Game()
        {
            i1 = new Input();
            c1 = new ComputerCard();
            o1 = new Output();
        }

        public void startGame()
        {
            int correctGuess = 0;
            i1.GetUserValues();
            for (int i = 0; i < 6; i++)
            {
                c1.GenerateValue();
            }
            cp = new CheckPlay(i1.GetUserCard(), c1);
            correctGuess = cp.Compare();
            o1.Write(correctGuess);
        }
    }
    
}
