using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Table
    {
       public bool Seat1 = true; 
        //true means empty seat
       public bool Seat2 = true;
       public bool Seat3 = true;
       public bool Seat4 = true;
       public bool TableIsFull = false; 

       public Table(bool seat1, bool seat2, bool seat3, bool seat4, bool tableIsFull)
        {
            Seat1 = seat1;
            Seat2 = seat2;
            Seat3 = seat3;
            Seat4 = seat4;
            TableIsFull = tableIsFull;
        }

        
    }

}
