using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Worst_Code
{
    class Adding
    {
        public bool sameNumber = false;
        public int result;
        public int multiplyBy = 3;
        public int input1;
        public int input2;

        public Adding()
        {
            

        }

        /*public bool SameNumber(int input1, int input2)
        {
            if ( input1 == input2 )
            {
                AddingTo(input1 , input2);
                return true;
            }
            else
            {
                return false;
            }
            
        }*/

        public int AddingTo(int input1, int input2)
        {
            int result = (input1 + input2) * multiplyBy;
            /*bool sameNumber = true;
            if (sameNumber == true )
            {
                
                sameNumber = false;
            }*/
            
            return result; 
        }


    }
}
