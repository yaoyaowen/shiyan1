using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace Bowling
{
    public class BowlingBall
    {  
       private int[] score=new int[20]
       {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
       
       private int SUMscore;

       public int SumScore()
       {int i;
       for (i = 0; i <= 19; i++)
           SUMscore += score[i]; 
       
       return SUMscore;
       }
    }
}
