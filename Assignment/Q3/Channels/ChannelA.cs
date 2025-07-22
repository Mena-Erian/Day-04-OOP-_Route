using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q3.Channels
{
    internal class ChannelA : IChannel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ChannelProtocol { get; set; }
        public string? News { get; set; }
    }
}
