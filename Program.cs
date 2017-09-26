using System;
using System.Threading.Tasks;
using Discord;

namespace Emilia
{
    class Program
    {
        Bot emilia = new Bot("ton token");

        static void Main(string[] args)=>    new Program().emilia.MainAsync().GetAwaiter().GetResult();
    }
}
