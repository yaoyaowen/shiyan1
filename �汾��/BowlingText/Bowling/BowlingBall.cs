﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class turn 
{
   public int mark;//mark=1是该轮全中
   public int firstScore;//1-9轮全中只有这个有分，分数为10
   public int secondScore;
   public int thirdScore;//只有第十轮可能有

}


namespace Bowling
{
    public class BowlingBall
    { public turn[] Aturn=new turn[11];
    
       private int SUMscore=0;

       public int SumScore()
       {int i;
       for (i = 0; i < 10; i++)
       SUMscore += TurnScore(i);
       return SUMscore;
       }

       private int TurnScore(int i)
       {
           int tempScore=0;
           
           if (i<=7  && Aturn[i].mark == 1)
           { tempScore = 10;
           if (Aturn[i + 1].mark == 1)
           {
               tempScore += 10;
               tempScore += Aturn[i + 2].firstScore;
           }
           }//if(i<7)


           if (i == 8 && Aturn[i].mark == 1)
           {   tempScore = 10;
               if (Aturn[9].mark == 1)
               tempScore += Aturn[9].firstScore + Aturn[9].secondScore;
                   
            }//if(i=8)


           if (i == 9 && Aturn[i].mark == 1)
           {
               tempScore += Aturn[9].firstScore + Aturn[9].secondScore + Aturn[9].thirdScore;
           
           }


   
           return tempScore;
           
       }
    }
}
