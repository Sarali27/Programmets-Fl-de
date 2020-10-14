using System.Collections.Generic;    
    
namespace Countdown    
{    
    internal class Highscore    
    {    
        List<int> highscore = new List<int>();    
            
        public void AddScore(int score)    
        {    
            highscore.Add(score);    
        }    
    
        public List<int> ReturnScore ()    
        {    
            return highscore;    
        }    
    }    
}