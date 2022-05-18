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
            bool state;
            for (int i = 0; i < 9; i++)
            {
                Tables.Add(new Table(i, true, true, true, true, false, "", "", "", ""));
               
            }
            
            
        }

        public List<Table> Retrieve()
        {
            return Tables;
        }

        public string GetTableState(int Id)
        {


                Id = Tables[Id].TableNumber;
                string state;
                if(Tables[Id].TableIsFull == false)
                {
               
                state = $"{Console.ForegroundColor = ConsoleColor.Green} Free!";
                return state;
                }
                else
                {
                    state = $"{ConsoleColor.Red} Full!";
                return state;
                }
            }

        }
        
           
    }
    

