using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PrometheusNew.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        [Command("Test")]
        public async Task Dickbag(string repeat)
        {
            await Context.Channel.SendMessageAsync(ToString());
        }
        
    }
}
