﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{
    public class Player
    {
        public Room currentRoom;

        public void EnterRoom()
        {
            if(currentRoom != null)
            {
                Console.WriteLine(currentRoom.ToString());
            }
        }
    }
}
