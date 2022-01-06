using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XkcdBot.Commands
{
    public abstract class CommandBase : ModuleBase<SocketCommandContext>
    {
        protected string Mention => Context.Message.Author.Mention;
    }
}
