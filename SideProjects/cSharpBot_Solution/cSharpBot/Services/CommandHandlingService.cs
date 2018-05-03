using System;
using System.Reflection;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace cSharpBot.Services
{
    public class CommandHandlingService
    {
        private readonly DiscordSocketClient _discord;
        private readonly CommandService _commands;
        private IServiceProvider _provider;

        public CommandHandlingService(IServiceProvider provider, DiscordSocketClient discord, CommandService commands)
        {
            _discord = discord;
            _commands = commands;
            _provider = provider;

            _discord.MessageReceived += MessageReceived;
        }

        public async Task InitializeAsync(IServiceProvider provider)
        {
            _provider = provider;
            await _commands.AddModulesAsync(Assembly.GetEntryAssembly());
            // Add additional initialization code here...
        }

        private async Task MessageReceived(SocketMessage rawMessage)
        {
            // Ignore messages from bots
            if (!(rawMessage is SocketUserMessage message)) return;
            if (message.Source != MessageSource.User) return;
            // Sets prefix
            int argPos = 0;
            if (!message.HasStringPrefix("!", ref argPos)) return;

            var context = new SocketCommandContext(_discord, message);
            var result = await _commands.ExecuteAsync(context, argPos, _provider);
            // AntiError
            if (result.Error.HasValue &&
                result.Error.Value != CommandError.UnknownCommand)
                /*Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{result.Error} : {result.ErrorReason}");
                Console.ResetColor();*/
                await context.Channel.SendMessageAsync(result.ToString());
        }
    }
}
