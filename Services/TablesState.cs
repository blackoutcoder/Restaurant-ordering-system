using System;
using System.Collections.Generic;
using ClassModels;

namespace Services
{
    public class TablesState
    {
        public List<Table> Tables;

        public TablesState()
        {
            Tables = new List<Table>();

            for (int i = 0; i < 9; i++)
            {
                Tables.Add(new Table(i, true, true, true, true, false));
            }
        }

        public List<Table> Retrieve()
        {
            return Tables;
        }
    }
    
}
