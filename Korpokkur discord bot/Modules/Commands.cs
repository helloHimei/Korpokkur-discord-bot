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
        public static int cooldownSlime = 0;
        public static int cooldownQG = 0;
        public static int cooldownTA = 0;
        public static int cooldownMino = 0;

        [Command("korpokkur kid")]
        public async Task KorpokkurKid()
        {
            await ReplyAsync("Korpokkur Kid");
        }

        [Command("Slime Guide")]
        public async Task SlimeDiagrams()
        {
            int currentSlime = DateTime.Now.Minute;

            if (cooldownSlime == 0)
            {
                await ReplyAsync("https://cdn.discordapp.com/attachments/818599989495857152/825732445949263903/slime-stand-here.png");
                await ReplyAsync("https://cdn.discordapp.com/attachments/818599989495857152/825577032741290014/slime-no-perception-plan.png");
                cooldownSlime = currentSlime;
            }
            else if (currentSlime - cooldownSlime < 5)
            {
                if (currentSlime + cooldownSlime > 62)
                {
                    await ReplyAsync("https://cdn.discordapp.com/attachments/818599989495857152/825732445949263903/slime-stand-here.png");
                    await ReplyAsync("https://cdn.discordapp.com/attachments/818599989495857152/825577032741290014/slime-no-perception-plan.png");
                    cooldownSlime = currentSlime;
                }
                else
                {
                    await ReplyAsync("You can only run this command every 5 mins");
                }
            }

            else
            {
                await ReplyAsync("https://cdn.discordapp.com/attachments/818599989495857152/825732445949263903/slime-stand-here.png");
                await ReplyAsync("https://cdn.discordapp.com/attachments/818599989495857152/825577032741290014/slime-no-perception-plan.png");
                cooldownSlime = currentSlime;
            }
        }

        [Command("Queen Guard Reflect")]
        public async Task QueenGuardReflect()
        {
            int currentQG = DateTime.Now.Minute;

            if (cooldownQG == 0)
            {
                await ReplyAsync("https://cdn.discordapp.com/attachments/818600116734394378/818605438555521044/image0.png");
                cooldownQG = currentQG;
            }
            else if (currentQG - cooldownQG < 5)
            {
                if (currentQG + cooldownQG > 62)
                {
                    await ReplyAsync("https://cdn.discordapp.com/attachments/818600116734394378/818605438555521044/image0.png");
                    cooldownQG = currentQG;
                }
                else
                {
                    await ReplyAsync("You can only run this command every 5 mins");
                }
            }
            else
            {
                await ReplyAsync("https://cdn.discordapp.com/attachments/818600116734394378/818605438555521044/image0.png");
                cooldownQG = currentQG;
            }
        }

        [Command("TA Guide")]
        public async Task TADiagrams()
        {
            int currentTA = DateTime.Now.Minute;

            if (cooldownTA == 0)
            {
                await ReplyAsync("https://cdn.discordapp.com/attachments/818600152834113556/818604710088802354/ladder.png");
                await ReplyAsync("https://cdn.discordapp.com/attachments/818600152834113556/825163815694893066/unknown.png");
                cooldownTA = currentTA;
            }
            else if (currentTA - cooldownTA < 5)
            {
                if (currentTA + cooldownTA > 62)
                {
                    await ReplyAsync("https://cdn.discordapp.com/attachments/818600152834113556/818604710088802354/ladder.png");
                    await ReplyAsync("https://cdn.discordapp.com/attachments/818600152834113556/825163815694893066/unknown.png");
                    cooldownTA = currentTA;
                }
                else
                {
                    await ReplyAsync("You can only run this command every 5 mins");
                }
            }
            else
            {
                await ReplyAsync("https://cdn.discordapp.com/attachments/818600152834113556/818604710088802354/ladder.png");
                await ReplyAsync("https://cdn.discordapp.com/attachments/818600152834113556/825163815694893066/unknown.png");
                cooldownTA = currentTA;
            }
        }

        [Command("Mino Guide")]
        public async Task MinotaurDiagrams()
        {
            int currentMino = DateTime.Now.Minute;

            if (cooldownMino == 0)
            {
                await ReplyAsync("https://cdn.discordapp.com/attachments/818600166558924842/825940534132342794/Untitled.png");
                cooldownMino = currentMino;
            }
            else if (currentMino - cooldownMino < 5)
            {
                if (currentMino + cooldownMino > 62)
                {
                    await ReplyAsync("https://cdn.discordapp.com/attachments/818600166558924842/825940534132342794/Untitled.png");
                    cooldownMino = currentMino;
                }
                else
                {
                    await ReplyAsync("You can only run this command every 5 mins");
                }
            }
            else
            {
                await ReplyAsync("https://cdn.discordapp.com/attachments/818600166558924842/825940534132342794/Untitled.png");
                cooldownMino = currentMino;
            }
        }

        [Command("!help")]
        public async Task HelpInfo()
        {
            await ReplyAsync("```Avaliable Commands\nSlime Guide\nQueen Guard Reflect\nTA Guide\nMino Guide```");
        }

    }
}
