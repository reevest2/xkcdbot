using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using RestSharp;
using XkcdBot.Models;

namespace XkcdBot.Commands
{
    public class PhotoCommand : CommandBase
    {
        [Command("comic")]
        public async Task HandleCommandAsync()
        {
            var restClient = new RestClient();
            var request = new RestRequest("https://xkcd.com/info.0.json");
            var response = await restClient.ExecuteAsync<ComicModel>(request);

            if (response.Data == null || string.IsNullOrEmpty(response.Data.Img))
            {
                await ReplyAsync("No comics found.");
            }
            else
            {
                await ReplyAsync(response.Data.Img);
            }
        }
    }
}
