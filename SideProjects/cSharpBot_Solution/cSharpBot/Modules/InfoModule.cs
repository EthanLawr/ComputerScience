using System;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace cSharpBot.Modules
{
    public class InfoModule : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        public async Task Help()
        {
            var eb = new EmbedBuilder();                               //Create Embed
            eb.WithTitle("Help menu");                                 //Set a title for the embed
            eb.WithColor(555555);                                      //Set the color of the embed
            eb.WithTimestamp(DateTime.Now);                            //Set the time of when the embed was made
            eb.WithDescription("Help\nInfo\nUserInfo\nEcho\nList");    //Show the commands of the bot
            await Context.Channel.SendMessageAsync("", false, eb);     //Empty message, No TTS (Text To Speech), Embed

        }
        [Command("info")]
        public Task Info()
            => ReplyAsync(        //Who or What am i?
                $"Hello, I am a bot called {Context.Client.CurrentUser.Username} written in Discord.Net 1.02\n");
        
        [Command("userinfo")]
        public async Task UserInfoAsync(IGuildUser user = null)
        {
            var userThing = user ?? Context.User as IGuildUser; //
            if (userThing == null) //Do i exist?
                return;
            var eb = new EmbedBuilder();
            eb.WithAuthor("UserInfo");
            eb.WithColor(565656);
            eb.WithThumbnailUrl(userThing.GetAvatarUrl().ToString());
            eb.WithTitle($"UserName: {userThing.Username}");
            eb.WithDescription($"User ID: {userThing.Id.ToString()}");
            eb.AddField($"Status: {userThing.Status.ToString()}", $"Total Roles: {userThing.RoleIds.Count - 1}", true);
            eb.AddField($"Joined Server:",  userThing.JoinedAt?.ToString("MM/dd/yyyy"), true);
            eb.AddField("Joined Discord:", $"{userThing.CreatedAt:MM/dd/yyyy}", true);
            eb.WithTimestamp(DateTime.Now); 
            await Context.Channel.SendMessageAsync("", false, eb);
            Fuck();
        }
        [Command("channelinfo")]
        public async Task ChannelInfo(ITextChannel channel = null)
        {
            var ch = (ITextChannel)Context.Channel;
            if (ch == null)
                return;
            //var usercount = (await ch.GetUsersAsync().Flatten());
            var eb = new EmbedBuilder();
            eb.WithAuthor("ChannelInfo");
            eb.WithColor(293670);
            eb.WithTitle(ch.Name);
            eb.WithDescription(ch.Topic.ToString());
            eb.AddField("Channel ID:", ch.Id.ToString(), true);
            eb.AddField("Created At:", $"{ch.CreatedAt:MM/dd/yyyy}", true);
            //eb.AddField("Users", usercount.ToString(), true);
            eb.WithTimestamp(DateTime.Now);
            await Context.Channel.SendMessageAsync("", false, eb);
        }
        [Command("echo")]
        public Task EchoAsync([Remainder] string text)
    // Insert a ZWSP before the text to prevent triggering other bots!
    => ReplyAsync('\u200B' + text);

        // 'params' will parse space-separated elements into a list
        [Command("list")]
        public Task ListAsync(params string[] objects)
            => ReplyAsync("You listed: " + string.Join("; ", objects));

        public static string Fuck()
        {
            return "no u";
        }
    }
}