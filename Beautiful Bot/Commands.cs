﻿using BotTools.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.WebSocket;
using Discord;
using System.Collections.Specialized;
using Config.Json;
using Discord.Commands;
using System.Threading;
using BotTools.Handlers;

namespace Beautiful_Bot
{
    //sends a DM
    //await msg.Author.GetOrCreateDMChannelAsync();
    //await msg.Author.SendMessageAsync("MESSAGE");

    class Config : IJsonConfig
    {
        public List<string> Registered;

        public void LoadDefaults()
        {
            Registered = new List<string>();
        }
    }

    class Help : IDiscordCommand
    {
        public string Name => "help";

        public string Syntax => "";

        public string Permission => "default";

        string IDiscordCommand.Help => "";

        public async Task ExecuteAsync(SocketUserMessage msg, string[] parameters)
        {

            EmbedBuilder eb = new EmbedBuilder();
            EmbedBuilder eb1 = new EmbedBuilder();
            EmbedBuilder eb2 = new EmbedBuilder();
            EmbedBuilder eb3 = new EmbedBuilder();

            await msg.DeleteAsync();


            //Beautiful Bot Commands
            eb.AddField("Command: ;;help", "**Summary:** Shows all neccesary commands.");
            eb.AddField("Command: ;;test", "**Summary:** A command used by CruXial to test out different features.");
            eb.AddField("Command: ;;prefixes", "**Summary:** Shows all bot Prefixes.");
            eb.AddField("Command: ;;roulette", "**Summary:** A fun command based of off Russian Roulette.");
            eb.AddField("Command: ;;staff", "**Summary:** Shows a list of all the current Unturned Server moderators");
            eb.AddField("Command: ;;VIP", "**Summary:** Shows all the advantages you get by donating");

            await msg.Author.GetOrCreateDMChannelAsync();
            await msg.Author.SendMessageAsync("**Beautiful Bot**", embed: eb);
        }
    }

    class Test : IDiscordCommand
    {
        public string Name => "test";

        public string Help => "";

        public string Syntax => "";

        public string Permission => "Default";

        public async Task ExecuteAsync(SocketUserMessage msg, string[] parameters)
        {
            var sentMsg = await msg.Channel.SendMessageAsync("Approved!");

            await msg.Author.GetOrCreateDMChannelAsync();

            var sentMsgDM = await msg.Channel.SendMessageAsync("Approved!");

            await Task.Delay(10000);
            await msg.DeleteAsync();
            await sentMsg.DeleteAsync();
            await sentMsgDM.DeleteAsync();
        }
    }

    class Prefixes : IDiscordCommand
    {
        public string Name => "Prefixes";

        public string Help => "";

        public string Syntax => "";

        public string Permission => "Default";

        public async Task ExecuteAsync(SocketUserMessage msg, string[] parameters)
        {
            EmbedBuilder eb = new EmbedBuilder();
            eb.AddField("Name: Beautiful Bot", "Prefix: ;;");
            eb.AddField("Name: Dyno", "Prefix: &");
            eb.AddField("Name: !Music Bot", "Prefix: /");
            eb.AddField("Name: Mee6", "Prefix: !");

            var sentMsg = await msg.Channel.SendMessageAsync("", embed: eb);

            await Task.Delay(10000);
            await msg.DeleteAsync();
            await sentMsg.DeleteAsync();
        }
    }

    class Roulette : IDiscordCommand
    {
        public string Name => "roulette";

        public string Help => "";

        public string Syntax => "";

        public string Permission => "default";

        public async Task ExecuteAsync(SocketUserMessage msg, string[] parameters)
        {
            EmbedBuilder eb = new EmbedBuilder();
            eb.AddField("1/6 Bullets in the chamber", ";;roulette_1");
            eb.AddField("2/6 Bullets in the chamber", ";;roulette_2");
            eb.AddField("3/6 Bullets in the chamber", ";;roulette_3");
            eb.AddField("4/6 Bullets in the chamber", ";;roulette_4");
            eb.AddField("5/6 Bullets in the chamber", ";;roulette_5");

            var sentMsg = await msg.Channel.SendMessageAsync("This is a virtual 6-chamber Revoler, to proceed type one of the following commands.", embed: eb);

            await Task.Delay(10000);
            await msg.DeleteAsync();
            await sentMsg.DeleteAsync();
        }
    }

    class Roulette1 : IDiscordCommand
    {
        public string Name => "roulette_1";

        public string Help => "";

        public string Syntax => "";

        public string Permission => "default";

        public async Task ExecuteAsync(SocketUserMessage msg, string[] parameters)
        {
            var randomObject = new Random();

            var sentMsg = await msg.Channel.SendMessageAsync("Rolling Chamber...");
            string msg1 = "";
            await Task.Delay(2000);

            switch (randomObject.Next(1, 6 + 1))
            {
                case 2:
                    msg1 = $"**BOOM** {msg.Author.Mention} Will forever be missed!";
                    break;

                default:
                    msg1 = $"*click* {msg.Author.Mention} Gets to live another day!";
                    break;
            }
            var sentMsg1 = await msg.Channel.SendMessageAsync(msg1);

            await Task.Delay(10000);

            await sentMsg.DeleteAsync();
            await sentMsg1.DeleteAsync();
            await msg.DeleteAsync();
        }
    }

    class Roulette2 : IDiscordCommand
    {
        public string Name => "roulette_2";

        public string Help => "";

        public string Syntax => "";

        public string Permission => "default";

        public async Task ExecuteAsync(SocketUserMessage msg, string[] parameters)
        {
            var randomObject = new Random();

            var sentMsg = await msg.Channel.SendMessageAsync("Rolling Chamber...");
            string msg1 = "";
            await Task.Delay(2000);

            switch (randomObject.Next(1, 6 + 1))
            {
                case 2:
                    msg1 = $"**BOOM** {msg.Author.Mention} Will forever be missed!";
                    break;

                case 3:
                    msg1 = $"**BOOM** {msg.Author.Mention} Will forever be missed!";
                    break;

                default:
                    msg1 = $"*click* {msg.Author.Mention} Gets to live another day!";
                    break;
            }
            var sentMsg1 = await msg.Channel.SendMessageAsync(msg1);

            await Task.Delay(10000);

            await sentMsg.DeleteAsync();
            await sentMsg1.DeleteAsync();
            await msg.DeleteAsync();
        }
    }

    class Roulette3 : IDiscordCommand
    {
        public string Name => "roulette_3";

        public string Help => "";

        public string Syntax => "";

        public string Permission => "default";

        public async Task ExecuteAsync(SocketUserMessage msg, string[] parameters)
        {
            var randomObject = new Random();

            var sentMsg = await msg.Channel.SendMessageAsync("Rolling Chamber...");
            string msg1 = "";
            await Task.Delay(2000);

            switch (randomObject.Next(1, 6 + 1))
            {
                case 2:
                    msg1 = $"**BOOM** {msg.Author.Mention} Will forever be missed!";
                    break;

                case 3:
                    msg1 = $"**BOOM** {msg.Author.Mention} Will forever be missed!";
                    break;

                case 6:
                    msg1 = $"**BOOM** {msg.Author.Mention} Will forever be missed!";
                    break;

                default:
                    msg1 = $"*click* {msg.Author.Mention} Gets to live another day!";
                    break;
            }
            var sentMsg1 = await msg.Channel.SendMessageAsync(msg1);

            await Task.Delay(10000);

            await sentMsg.DeleteAsync();
            await sentMsg1.DeleteAsync();
            await msg.DeleteAsync();
        }
    }

    class Roulette4 : IDiscordCommand
    {
        public string Name => "roulette_4";

        public string Help => "";

        public string Syntax => "";

        public string Permission => "default";

        public async Task ExecuteAsync(SocketUserMessage msg, string[] parameters)
        {
            var randomObject = new Random();

            var sentMsg = await msg.Channel.SendMessageAsync("Rolling Chamber...");
            string msg1 = "";
            await Task.Delay(2000);

            switch (randomObject.Next(1, 6 + 1))
            {
                case 1:
                    msg1 = $"*click* {msg.Author.Mention} Gets to live another day!";
                    break;

                case 4:
                    msg1 = $"*click* {msg.Author.Mention} Gets to live another day!";
                    break;

                default:
                    msg1 = $"**BOOM** {msg.Author.Mention} Will forever be missed!";
                    break;
            }
            var sentMsg1 = await msg.Channel.SendMessageAsync(msg1);

            await Task.Delay(10000);

            await sentMsg.DeleteAsync();
            await sentMsg1.DeleteAsync();
            await msg.DeleteAsync();
        }
    }

    class Roulette5 : IDiscordCommand
    {
        public string Name => "roulette_5";

        public string Help => "";

        public string Syntax => "";

        public string Permission => "default";

        public async Task ExecuteAsync(SocketUserMessage msg, string[] parameters)
        {
            var randomObject = new Random();

            var sentMsg = await msg.Channel.SendMessageAsync("Rolling Chamber...");
            string msg1 = "";
            await Task.Delay(2000);

            switch (randomObject.Next(1, 6 + 1))
            {
                case 5:
                    msg1 = $"*click* {msg.Author.Mention} Gets to live another day!";
                    break;

                default:
                    msg1 = $"**BOOM** {msg.Author.Mention} Will forever be missed!";
                    break;
            }
            var sentMsg1 = await msg.Channel.SendMessageAsync(msg1);

            await Task.Delay(10000);

            await sentMsg.DeleteAsync();
            await sentMsg1.DeleteAsync();
            await msg.DeleteAsync();
        }
    }

    class Staff : IDiscordCommand
    {
        public string Name => "staff";

        public string Help => "";

        public string Syntax => "";

        public string Permission => "default";

        public async Task ExecuteAsync(SocketUserMessage msg, string[] parameters)
        {
            EmbedBuilder eb = new EmbedBuilder();

            eb.AddField("Username: @Tactical Pug", "Steam Account: http://steamcommunity.com/id/Beafraid98/");
            eb.AddField("Username: @TheWolfenGang XP", "Steam Account: http://steamcommunity.com/profiles/76561198252378620/");
            eb.AddField("Username: @Rize-Duckii", "Steam Account: http://steamcommunity.com/profiles/76561198114939491/");

            var sentMsg = await msg.Channel.SendMessageAsync("All the current server moderators.", embed: eb);

            await Task.Delay(10000);
            await msg.DeleteAsync();
            await sentMsg.DeleteAsync();
        }
    }

    class Apply : IDiscordCommand
    {
        public string Name => "apply";

        public string Help => "";

        public string Syntax => "";

        public string Permission => "default";

        public async Task ExecuteAsync(SocketUserMessage msg, string[] parameters)
        {
            if (Program.Configuration.Instance.Registered.Contains(msg.Author.Mention))

            {
                await msg.Author.GetOrCreateDMChannelAsync();
                await msg.Author.SendMessageAsync("You have already applied!");

                await msg.DeleteAsync();

                return;
            }

            else
            {
                await msg.Author.GetOrCreateDMChannelAsync();
                await msg.Author.SendMessageAsync("You have been registered!");

                Program.Configuration.Instance.Registered.Add(msg.Author.Username);

                Program.Configuration.Save();

                await msg.DeleteAsync();
            }
        }
    }

    class CheckApply : IDiscordCommand
    {
        public string Name => "checkapply";

        public string Help => "";

        public string Syntax => "";

        public string Permission => "admin";

        public async Task ExecuteAsync(SocketUserMessage msg, string[] parameters)
        {
            await msg.Author.GetOrCreateDMChannelAsync();
            await msg.Author.SendMessageAsync(Program.Configuration.Instance.Registered.Count > 0 ? string.Join("\n", Program.Configuration.Instance.Registered) : "No one is registered");

            Program.Configuration.Save();

            await msg.DeleteAsync();
        }
    }

    class ApplyClear : IDiscordCommand
    {
        public string Name => "applyclear";

        public string Help => "";

        public string Syntax => "";

        public string Permission => "admin";

        public async Task ExecuteAsync(SocketUserMessage msg, string[] parameters)
        {
            Program.Configuration.Instance.Registered.Clear();

            Program.Configuration.Save();

            await msg.DeleteAsync();
        }
    }

    class VIPadvantages : IDiscordCommand
    {
        public string Name => "VIP";

        public string Help => "";

        public string Syntax => "";

        public string Permission => "default";

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task ExecuteAsync(SocketUserMessage msg, string[] parameters)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            Task.Run(async () =>
            {
                var msg1 = await msg.Channel.SendMessageAsync("**Why buy VIP?:**\n -You get an ingame name color\n -You get the permission to warp anywhere on the map every 30 minutes \n -You can use /heal every 3 minutes\n -You get alot of cooldowns on commands such as /i and /v \n -You get the 'Donor' discord role.");

                await Task.Delay(10000);

                await msg1.DeleteAsync();
                await msg.DeleteAsync();
            });
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        }
    }

    class Advertise : IDiscordCommand
    {
        public string Name => "Advertise";

        public string Help => "Use this command to advertise.";

        public string Syntax => "advertisement";

        public string Permission => "default";

        public async Task ExecuteAsync(SocketUserMessage input, string[] parameters)
        {
            await input.DeleteAsync();

            var botmsg = await input.Channel.SendMessageAsync($"```{input.Content.Replace(";;advertise", "")}```");
        }
    }

    class Ban : ModuleBase<CommandContext>, IDiscordCommand
    {
        public string Name => "ban";

        public string Help => "moderation command";

        public string Syntax => "<@username> (reason)";

        public string Permission => "admin";

        public async Task ExecuteAsync(SocketUserMessage msg, string[] parameters)
        {
            if (parameters.Length < 2) return;

            string targetId = msg.MentionedUsers.Count == 1 ? msg.MentionedUsers.First().Id.ToString() : parameters[0];
            SocketGuild server = ((SocketGuildChannel)msg.Channel).Guild;
            SocketGuildUser target = server.Users.FirstOrDefault(x => x.Id.ToString() == targetId);

            if (target == null)
            {
                await msg.Channel.SendMessageAsync($"Correct Usage: `;;ban <@username> (reason)`");
                return;
            }

            var allBans = await server.GetBansAsync();
            bool isBanned = allBans.Any(x => x.User.Id == target.Id);

            if (!isBanned)
            {
                var senderHighest = ((SocketGuildUser)msg.Author).Hierarchy;

                if (target.Hierarchy < senderHighest)
                {
                    try
                    {
                        var dmChannel = await target.GetOrCreateDMChannelAsync();
                        await dmChannel.SendMessageAsync($"You have been banned from **{server.Name}** by Moderator **{msg.Author}**. Reason: **{String.Join(" ", parameters.Skip(1))}**");
                    }
                    catch (Exception e)
                    {
                        await msg.Author.GetOrCreateDMChannelAsync();
                        await msg.Author.SendMessageAsync($"Failed to send DM to **{target.Username}.\nError message: {e.Message}");
                    }

                    var TextChannelLogs = Program.client.GetChannel(353561970038931458) as SocketTextChannel;

                    EmbedBuilder eb = new EmbedBuilder();

                    eb.AddField("Case:", "Ban");
                    eb.AddField("Target", $"{target.Mention}");
                    eb.AddField($"Moderator: ", $"{msg.Author.Mention}");
                    eb.AddField($"Reason:", $"{String.Join(" ", parameters.Skip(1))}");

                    await TextChannelLogs.SendMessageAsync("", embed: eb);

                    await server.AddBanAsync(target);
                    await msg.Channel.SendMessageAsync($"**{target.Username}** has been banned by Moderator **{msg.Author}**. Reason: **{String.Join(" ", parameters.Skip(1))}**");
                }
            }
        }
    }

    class Shutdown : IDiscordCommand
    {
        public string Name => "Shutdown";

        public string Help => "shuts down the bot";

        public string Syntax => "";

        public string Permission => "admin";

        public async Task ExecuteAsync(SocketUserMessage msg, string[] parameters)
        {
            await msg.Channel.SendMessageAsync("**Shutting Down...**");
            await Program.client.StopAsync();
            Program.cancelSrc.Cancel();
        }
    }
}

