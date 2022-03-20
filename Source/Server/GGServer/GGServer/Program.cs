using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;

namespace GGServer
{
    class MainClass
    {
        static Queue<Instruction> Insts;
        public static void Main(string[] args)
        {
            insts = new Queue<Instruction>();

            Thread update = new Thread(update);
            update.Start();

            for(; ; )
            {
                if(Insts.Count > 0)
                {
                    exec(Insts.Dequeue());
                }
            }
        }

        static void update()
        {
            
        }

        static void exec(Instruction i)
        {
            
        }
    }
}
