using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Korpokkur_discord_bot.Modules
{
    
    public class Commands : ModuleBase<SocketCommandContext>
    {
        public static long cooldownSlime = 0;
        public static long cooldownQG = 0;
        public static long cooldownTA = 0;
        public static long cooldownMino = 0;

        [Command("korpokkur kid")]
        public async Task KorpokkurKid()
        {
            await ReplyAsync("Korpokkur Kid");
        }

        [Command("Slime Guide")]
        public async Task SlimeDiagrams()
        {
            if (cooldownSlime < DateTimeOffset.Now.ToUnixTimeSeconds() - 300)
            {
                await ReplyAsync("https://cdn.discordapp.com/attachments/818599989495857152/825732445949263903/slime-stand-here.png");
                await ReplyAsync("https://cdn.discordapp.com/attachments/818599989495857152/825577032741290014/slime-no-perception-plan.png");
                cooldownSlime = DateTimeOffset.Now.ToUnixTimeSeconds();
            }
        }

        [Command("QG Guide")]
        public async Task QueenGuardReflect()
        {
            if (cooldownQG < DateTimeOffset.Now.ToUnixTimeSeconds() - 300)
            {
                await ReplyAsync("https://cdn.discordapp.com/attachments/818600116734394378/818605438555521044/image0.png");
                cooldownQG = DateTimeOffset.Now.ToUnixTimeSeconds();
            }
        }

        [Command("TA Guide")]
        public async Task TADiagrams()
        {
            if (cooldownTA < DateTimeOffset.Now.ToUnixTimeSeconds() - 300)
            {
                await ReplyAsync("https://cdn.discordapp.com/attachments/818600152834113556/818604710088802354/ladder.png");
                await ReplyAsync("https://cdn.discordapp.com/attachments/818600152834113556/825163815694893066/unknown.png");
                cooldownTA = DateTimeOffset.Now.ToUnixTimeSeconds();
            }
        }

        [Command("Mino Guide")]
        public async Task MinotaurDiagrams()
        {
            if (cooldownMino < DateTimeOffset.Now.ToUnixTimeSeconds() - 300)
            {
                await ReplyAsync("https://cdn.discordapp.com/attachments/818600166558924842/825940534132342794/Untitled.png");
                cooldownMino = DateTimeOffset.Now.ToUnixTimeSeconds();
            }
        }

        [Command("korpokkur help")]
        public async Task HelpInfo()
        {
            await ReplyAsync("```Avaliable Commands\nSlime Guide\nQG Guide\nTA Guide\nMino Guide```");
        }
    }
}
