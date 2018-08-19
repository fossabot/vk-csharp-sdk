using System;
using System.IO;
using Newtonsoft.Json;
using Vk.CSharp.Sdk.External;
using Vk.CSharp.Sdk.Global.Models;

namespace Vk.CSharp.Sdk.App.Source
{
    internal class Data
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }

    internal class Program
    {
        protected static Data Data => GetData(GetJson());

        private static void Main()
        {
            // На данный момент авторизация производится по уже полученному ключу доступа.
            // Полученный ключ доступа необходимо вставить в файл "access_token.json".
            VkApiProvider.Authorize(new AuthorizationData(Data.AccessToken));

            Console.WriteLine(
                VkApiProvider
                    .GetEnvironment()
                    .AccessToken
            );

            Console.ReadKey();
        }

        private static Data GetData(string json) =>
            JsonConvert.DeserializeObject<Data>(json);

        private static string GetJson() =>
            File.ReadAllText(GetCurrentProjectFullPath() + @"/Data/access_token.json");

        private static string GetCurrentProjectFullPath() =>
            Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())));
    }
}