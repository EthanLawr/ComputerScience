using Discord;
using Discord.Commands;
using Discord.WebSocket;
using cSharpBot.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
namespace cSharpBot
{
    class Program
    {
        static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();
        private DiscordSocketClient _client;
        public async Task MainAsync()
        {

            _client = new DiscordSocketClient();
            _client.Log += LogAsync;
            _client.Ready += ReadyAsync;
            _client.MessageReceived += MessageReceivedAsync;
            var services = ConfigureServices();
            await services.GetRequiredService<CommandHandlingService>().InitializeAsync(services);
            await _client.LoginAsync(TokenType.Bot, Lol fuck off cunt.);
            await _client.StartAsync();
            await Task.Delay(-1);
        }

        private IServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
                // Base
                .AddSingleton(_client)
                .AddSingleton<CommandService>()
                .AddSingleton<CommandHandlingService>()
                // Logging
                .AddLogging()
                .BuildServiceProvider();
        }

        #region Events
        private Task LogAsync(LogMessage log)
        {
            Console.WriteLine(log.ToString());
            return Task.CompletedTask;
        }
        private Task ReadyAsync()
        {
            Console.WriteLine($"{_client.CurrentUser} is connected!");
            return Task.CompletedTask;
        }
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        private async Task MessageReceivedAsync(SocketMessage message)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            // The bot should never respond to itself.
            if (message.Author.Id == _client.CurrentUser.Id)
                return;
        }
        #endregion
    }
}
