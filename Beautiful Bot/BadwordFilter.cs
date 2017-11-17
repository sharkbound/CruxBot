using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Beautiful_Bot;
using Crux.Config;

namespace BadWordFilter
{
    public class BadwordFilter
    {
        internal static async Task OnChat(SocketMessage arg)
        {
            await Task.Run(async () =>
            {
                if (arg is SocketUserMessage msg)
                {
                    var BannedWords = new List<string> { "test", "nigga", "", ""};

                    var message = msg.Content;

                    foreach (var badWord in BannedWords)
                    {

                        if (message.ToLower().Contains(badWord))
                        {
                            await msg.DeleteAsync();

                            await msg.Channel.SendMessageAsync($"{msg.Author.Mention}, watch your language!!");

                            var msg1 = await msg.Channel.SendMessageAsync($";;warn {msg.Author.Mention} Using bad words");

                            await msg1.DeleteAsync();

                            break;
                        }
                        break;
                    }
                }
            });
            
        }
    }
}
