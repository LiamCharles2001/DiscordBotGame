using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownOfDiscord.Commands
{
    public class DebugCommands : BaseCommandModule
    {
        [Command("ping")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Pong").ConfigureAwait(false);
        }

        [Command("add")]
        public async Task Add(CommandContext ctx, int numOne, int numTwo)
        {
            await ctx.Channel.SendMessageAsync((numOne + numTwo).ToString()).ConfigureAwait(false);
        }

        [Command("who")]
        public async Task Who(CommandContext ctx)
        {
            string data = ctx.User.ToString();

            await ctx.Channel.SendMessageAsync(data).ConfigureAwait(false);
        }
    }
}
