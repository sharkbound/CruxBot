using BotTools.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.WebSocket;

namespace Beautiful_Bot.Commands
{
    class CommandRR : IDiscordCommand
    {
        static Random r = new Random();
        public string Name => "rr";

        public string Help => "";

        public string Syntax => "";

        public string Permission => "rr";

        public async Task ExecuteAsync(SocketUserMessage msg, string[] parameters)
        {
            if (parameters.Length != 1)
            {
                await msg.Channel.SendMessageAsync("you must supply the number of chambers you want");
                return;
            }

            if (!int.TryParse(parameters[0], out int rounds))
            {
                await msg.Channel.SendMessageAsync("please enter a number for the number of chambers you want");
                return;
            }

            if (r.Next(rounds) == 0)
            {
                await msg.Channel.SendMessageAsync("**BOOM**");
            }
            else
            {
                await msg.Channel.SendMessageAsync("**click**");
            }
        }
    }
}
