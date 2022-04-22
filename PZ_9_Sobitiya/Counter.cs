using System;
using System.Collections.Generic;
using System.Text;



namespace PZ_9_Sobitiya
{
    public class Counter
    {
        
        public int num;
        public Counter(int x)
        {
            num = x;
        }

        public void Numbers()
        {
            Cutch a = new Cutch();
            for (int i = 1; i < 1001; i++)
            {
                a.ActiveateEvent(i);

                if (i == 800) break;
            }
        }
    }
}
