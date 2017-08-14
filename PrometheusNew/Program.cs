using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace PrometheusNew
{
    public class Program
    {
        static void Main(string[] args)
            => new Program().StartAsync().GetAwaiter().GetResult();
        
        private DiscordSocketClient _client;

        private CommandHandler _handler;

        public async Task StartAsync()
        {
            
            _client = new DiscordSocketClient();
            
            await _client.LoginAsync(TokenType.Bot, "MzQ2NDIxODAzMzM1Mjg2Nzg0.DHJ_kw.f2qMJ2E6wvzfTHYim_VCVmzXpws");

            await _client.StartAsync();

            _handler = new CommandHandler(_client);

            await Task.Delay(-1);
        }
    }
}