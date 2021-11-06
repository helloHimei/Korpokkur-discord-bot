using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Korpokkur_discord_bot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("korpokkur kid")]
        public async Task KorpokkurKid()
        {
            await ReplyAsync("Korpokkur Kid");
        }

        [Command("Slime Guide")]
        public async Task SlimeDiagrams()
        {
            await ReplyAsync("https://cdn.discordapp.com/attachments/818599989495857152/825732445949263903/slime-stand-here.png");
            await ReplyAsync("https://cdn.discordapp.com/attachments/818599989495857152/825577032741290014/slime-no-perception-plan.png");
        }

        [Command("Queen Guard Reflect")]
        public async Task QueenGuardReflect()
        {
            await ReplyAsync("https://cdn.discordapp.com/attachments/818600116734394378/818605438555521044/image0.png");
        }

        [Command("TA Guide")]
        public async Task TADiagrams()
        {
            await ReplyAsync("https://cdn.discordapp.com/attachments/818600152834113556/818604710088802354/ladder.png");
            await ReplyAsync("https://cdn.discordapp.com/attachments/818600152834113556/825163815694893066/unknown.png");
        }

        [Command("Mino Guide")]
        public async Task MinotaurDiagrams()
        {
            await ReplyAsync("https://cdn.discordapp.com/attachments/818600166558924842/825940534132342794/Untitled.png");
        }

        [Command("korpokkur help")]
        public async Task HelpInfo()
        {
            await ReplyAsync("```Avaliable Commands\nSlime Guide\nQueen Guard Reflect\nTA Guide\nMino Guide```");
        }
    }
}
