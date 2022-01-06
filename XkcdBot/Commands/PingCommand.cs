using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace XkcdBot.Commands
{
    public  class PingCommand : CommandBase
    {
        [Command("ping")]
        public async Task Ping()
        {
            await ReplyAsync("pong");
        }
    }
}
