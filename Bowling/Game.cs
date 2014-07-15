using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Game
    {
        public int final_score = 0,i=0;
        public int[] pin = new int[30];

        public void Roll(int pins)
        {
            if ((pins == 10)&&((i % 2) == 0))
            
            {
                pin[i] = pins;
                i++;
                pin[i] = 0;
                i++;
  
            }
            else
            {
                pin[i] = pins;
                i++;
            }

        }

        public int GetScore()
        {
            for (int j = 0; j < 20; j++)
            {
                if (pin[j] == 10)
                {
                    if ((j % 2) == 0)
                    {
                        if (((pin[j + 2]) == 10))
                        {
                            final_score += pin[j]+pin[j+2]+pin[j+4];
                        }
                        else
                        {
                            final_score = final_score + pin[j] + pin[j + 2] + pin[j + 3];
                        }
                        
                    }
                    else
                    {
                        final_score += pin[j] + pin[j + 1];
                    }
                }
                else if ((j % 2) == 0)
                {
                    if ((pin[j] + pin[j + 1]) == 10)
                    {
                        final_score += pin[j] + pin[j + 1] + pin[j + 2];
                        j++;
                    }
                    else
                        final_score += pin[j];
                }
                else
                    final_score += pin[j];
            }
            return final_score;
        }

    }
}
