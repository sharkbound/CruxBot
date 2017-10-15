using BotTools;
using BotTools.Handlers;
using Config.Json;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;

namespace Beautiful_Bot
{
    public interface IDependencyMap
    {
        void Add<T>(T obj) where T : class;
    }

    public class Program
    {
        static void Main(string[] args)
        {
            new Program().MainAsync().GetAwaiter().GetResult();
        }

        class CLV
        {
            static string class_level;
        }

        internal static DiscordSocketClient client;
        internal static CancellationTokenSource cancelSrc = new CancellationTokenSource();

        public async Task MainAsync()
        {
            Permissions.Load();

            client = new DiscordSocketClient();
            CommandHandler handler = new CommandHandler(client, ";;");

            await client.SetGameAsync(";;help");

            var token = "MzY2NTY2NzUzNDk4ODI0NzA1.DLuvqg.kkIzlN7uPy8lRoMkcgG2kkCu-jM";


            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();

            await Task.Delay(-1, cancelSrc.Token);
        }

        internal static JsonConfig<Config> Configuration = new JsonConfig<Config>("Employment List");
    }
}   