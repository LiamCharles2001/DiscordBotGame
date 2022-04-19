using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownOfDiscord.Discord;
using TownOfDiscord.Game;

namespace TownOfDiscord.Commands
{
    public class GameCommands : BaseCommandModule
    {
        private DiscordGame _game = new DiscordGame();

        [Command("Join")]
        [Description("Joins the game if the game hasn't started yet")]
        public async Task Join(CommandContext ctx)
        {
            Player player = new Player(ctx.User.Id, ctx.User.Username);

            if (_game.AddPlayer(player))
            {
                await ctx.Channel.SendMessageAsync($"{ctx.User.Username} was added to the game.").ConfigureAwait(false);
            }
            else
            {
                await ctx.Channel.SendMessageAsync($"{ctx.User.Username} is already in the game.").ConfigureAwait(false);
            }
        }

        [Command("Leave")]
        [Description("Takes you out of the game")]
        public async Task Leave(CommandContext ctx)
        {
            Player player = new Player(ctx.User.Id, ctx.User.Username);

            if (_game.RemovePlayer(player))
            {
                await ctx.Channel.SendMessageAsync($"{ctx.User.Username} was removed from the game.").ConfigureAwait(false);
            }
            else
            {
                await ctx.Channel.SendMessageAsync($"{ctx.User.Username} was never added to the game.").ConfigureAwait(false);
            }
        }

        [Command("Start")]
        [Description("Starts the game once the minimum amount of players has joined")]
        public async Task Start(CommandContext ctx)
        {
            string issues = string.Empty;

            if (_game.HasStarted)
            {
                issues += "Game is already in progress.\n";
            }
            if (_game.Players.Count < _game.MinPlayers)
            {
                issues += $"Not enough players to start, {_game.MinPlayers} required\n";
            }

            if (issues != string.Empty)
            {
                await ctx.Channel.SendMessageAsync($"There is an issue!\n- {issues}").ConfigureAwait(false);
                return;
            }

            _game.CmdContext = ctx;
            if (_game.Start())
            {
                await ctx.Channel.SendMessageAsync($"Game has successfully Finished!").ConfigureAwait(false);
            }
            else
            {
                await ctx.Channel.SendMessageAsync($"Game is unable to start.").ConfigureAwait(false);
            }
        }

        [Command("Players")]
        [Description("Returns a list of all players who are in the game")]
        public async Task Players(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync($"Players: {_game.ToString()}.").ConfigureAwait(false);
        }
    }
}
