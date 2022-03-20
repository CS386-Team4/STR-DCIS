using System;
namespace GGServer
{
    public struct Instruction
    {
        public string IP { get; private set; }
        public byte[] body { get; private set; }

        public Instruction(string IP, byte[] body)
        {
            this.IP = IP;
            this.body = body;
        }
    }
}
