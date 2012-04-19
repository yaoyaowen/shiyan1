using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public struct turn 
{
   public int mark;//mark=1是该轮全中,mark=2是补中
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

       public void roll(int time,int firstScore, int secondScore)
       {
           if (firstScore == 10)
            Aturn[time - 1].mark = 1;
           else{
               if ((secondScore + firstScore) == 10)
                   Aturn[time - 1].mark = 2;
            }//else

           Aturn[time - 1].firstScore = firstScore;
           Aturn[time - 1].secondScore=secondScore;
       
       }

       public void roll(int time, int firstScore, int secondScore, int thirdScore)
       {
           if (firstScore == 10)
               Aturn[time - 1].mark = 1;
           else
           {
               if ((secondScore + firstScore) == 10)
                   Aturn[time - 1].mark = 2;
           }//else

           Aturn[time - 1].firstScore = firstScore;
           Aturn[time - 1].secondScore = secondScore;
           Aturn[time - 1].thirdScore = thirdScore;
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
           else {
               tempScore = tempScore + Aturn[i + 1].firstScore + Aturn[i + 1].secondScore;
           }//else

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

////////////////////////////////////////////////////////
        if (Aturn[i].mark == 2&&i<9)
           tempScore = 10 + Aturn[i + 1].firstScore;


        if (Aturn[i].mark == 2 && i == 9)
            tempScore = 10 + Aturn[9].thirdScore;



           return tempScore;
           
       }
    }



}
