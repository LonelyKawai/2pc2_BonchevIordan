using System;
using System.Collections.Generic;
using System.Text;

namespace PZ_9_Sobitiya
{
    public class Cutch
    {
        
        public event Delegate num_get;

        public void ActiveateEvent(int now)
        {

            if (now == 200)
            {
                num_get = Dvesti;
            }
            else if (now == 800)
            {
                num_get = Vosemsot;
            }
            else num_get = null;
            if (num_get != null) num_get();
        }
        void Dvesti()
        {
            Console.WriteLine("Вот ты и попался друг, 200");
        }
        void Vosemsot()
        {
            Console.WriteLine("Как рулить?! 800");
        }
    }
}
