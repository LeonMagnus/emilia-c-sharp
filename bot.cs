using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;
using System;

namespace Emilia
{
    class Bot
    {
        protected DiscordSocketClient bot;
        private string token;
        public Bot(string tok)
        {
            //initialise

            token = tok;

        }
        public async Task MainAsync()
        {
            bot = new DiscordSocketClient();
            await bot.LoginAsync(TokenType.Bot, token);
            await bot.SetGameAsync("toto pang");
            await bot.StartAsync();
            bot.MessageReceived += MessageReceived;
            await Task.Delay(-1);
        }
        private async Task MessageReceived(SocketMessage mes)
        {
            EmbedBuilder test = new EmbedBuilder()
           .WithColor(0xFF0000);
            test.Description = "je teste" ;
            Embed toto;
            toto = test;
            test.WithFooter("by " + mes.Author.Username,mes.Author.GetAvatarUrl());
            if (mes.Content == "test")
 
            {
                await mes.Channel.SendMessageAsync("lol "+ toto.Description) ;
                await mes.Channel.SendMessageAsync("magic lol",false,test);
            }

        }
    }
}