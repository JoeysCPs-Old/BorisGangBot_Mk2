﻿using Discord.Commands;
using System.Threading.Tasks;

namespace BorisGangBot_Mk2.Modules
{
    [Name("Misc. Commands")]
    public class MiscModule : ModuleBase<SocketCommandContext>
    {
        [Command("source")]
        [Summary("Gives a link to Boris Gang Bot's source code.")]
        public async Task SourceAsync()
        {
            await ReplyAsync($"https://github.com/JoeysCodingProjects/BorisGangBot_Mk2");
        }
    }
}
