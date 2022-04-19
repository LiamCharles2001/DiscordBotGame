using DSharpPlus.CommandsNext;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity.Extensions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TownOfDiscord.Game;

namespace TownOfDiscord.Discord
{
    class DiscordGame : Game.Game
    {
        public CommandContext CmdContext { get; set; }
        protected override void Setup()
        {
            if (Players.Count < MinPlayers - 1)
                throw new ArgumentOutOfRangeException();

            HasStarted = true;
            Utilities.Shuffle(Players);

            for (int i = 0; i < Players.Count; i++)
            {
                // 1 in 3 is the Murderer
                if (i % 3 == 0)
                {
                    Players[i].role = Role.Murderer;
                }
                else
                {
                    Players[i].role = Role.Innocent;
                }
                MessagePlayerRole(CmdContext, Players[i].ID, Players[i].role).ConfigureAwait(false);
            }
        }
        protected override void Run()
        {
            while(true)
            {
                //Day
                CmdContext.Channel.SendMessageAsync($"Vote someone out.").ConfigureAwait(false);

                //Public voting

                //kill person
                //RemovePlayer();

                //reveal
                CmdContext.Channel.SendMessageAsync($"Only {this.ToString()} are left.");

                //Check game conditions
                if (!IsTeamAlive(Role.Innocent))
                {
                    CmdContext.Channel.SendMessageAsync($"All Innocents are dead. Murderers win.").ConfigureAwait(false);
                    break;
                }
                else if(!IsTeamAlive(Role.Murderer))
                {
                    CmdContext.Channel.SendMessageAsync($"All Murderers are dead. Innocents win.").ConfigureAwait(false);
                    break;
                }

                //Night
                CmdContext.Channel.SendMessageAsync($"Its a nice cool night..").ConfigureAwait(false);

                //Ask Murderers who to kill
                foreach (Player currentPlayer in Players)
                {
                    if (currentPlayer.role == Role.Murderer)
                        MessagePlayerMurderOptions(CmdContext, currentPlayer.ID, this.ToString()).ConfigureAwait(false);
                }

                //Reveal
                CmdContext.Channel.SendMessageAsync($"Only {this.ToString()} are left.");

                //Check game conditions
                if (!IsTeamAlive(Role.Innocent))
                {
                    CmdContext.Channel.SendMessageAsync($"All Innocents are dead. Murderers win.").ConfigureAwait(false);
                    break;
                }
            }
        }

        public async Task MessagePlayerRole(CommandContext ctx, ulong playerID, Role role)
        {
            DiscordMember member = await ctx.Guild.GetMemberAsync(playerID).ConfigureAwait(false);
            DiscordDmChannel channel = await member.CreateDmChannelAsync().ConfigureAwait(false);
            await channel.SendMessageAsync($"Psst, your role is {role}.").ConfigureAwait(false);
        }

        public async Task MessagePlayerMurderOptions(CommandContext ctx, ulong playerID, string options)
        {
            DiscordMember member = await ctx.Guild.GetMemberAsync(playerID).ConfigureAwait(false);
            DiscordDmChannel channel = await member.CreateDmChannelAsync().ConfigureAwait(false);
            await channel.SendMessageAsync($"Hey Murderer, Its time to go into someone's house and slay them!\nWho would you like it to be?\nAnswer by typing their name here.\n{options}").ConfigureAwait(false);
            
            var interactivity = ctx.Client.GetInteractivity();

            Player? playerToKill;
            while (true)
            {
                var message = await interactivity.WaitForMessageAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);

                if (message.ToString() != null)
                {
                    playerToKill = Players.Find(p => p.name == message.ToString());

                    if (playerToKill == null)
                        continue;

                    if(RemovePlayer(playerToKill))
                        break;
                }
            }

            await ctx.Channel.SendMessageAsync($"{playerToKill.name} has been killed.");
        }
    }
}
