using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassModels
{
    public class Table
    {
        public int TableNumber;
       public bool Seat1 = true; 
        //true means empty seat
       public bool Seat2 = true;
       public bool Seat3 = true;
       public bool Seat4 = true;
       public bool TableIsFull = false;
        public string Seat1Name;
        public string Seat2Name;
        public string Seat3Name;
        public string Seat4Name;

        public Table(int tableNumber, bool seat1, bool seat2, bool seat3, bool seat4, bool tableIsFull, string seat1Name, string seat2Name, string seat3Name, string seat4Name)
        {
            TableNumber = tableNumber;
            Seat1 = seat1;
            Seat2 = seat2;
            Seat3 = seat3;
            Seat4 = seat4;
            TableIsFull = tableIsFull;
            Seat1Name = seat1Name;
            Seat2Name = seat2Name;
            Seat3Name = seat3Name;
            Seat4Name = seat4Name;
        }



    }

}
