using System;
using Vk.CSharp.Sdk.External;
using Vk.CSharp.Sdk.Global.Models;

namespace Vk.CSharp.Sdk.App.Source
{
    internal class Program
    {
        private static string AccessToken =>
            "access_token";

        private static void Main()
        {
            VkApiProvider
                .GetVkApi()
                .Authorize(new AuthorizationData(AccessToken));

            Console.WriteLine(
                VkApiProvider
                    .GetVkApi()
                    .GetEnvironment()
                    .Version
            );

            Console.WriteLine(
                VkApiProvider
                    .GetVkApi()
                    .GetEnvironment()
                    .AccessToken
            );

            Console.WriteLine(
                ReferenceEquals(VkApiProvider.GetAccount(), VkApiProvider.GetVkApi().GetAccount())
            );

            var account = VkApiProvider.GetAccount();

            Console.WriteLine(
                ReferenceEquals(VkApiProvider.GetAccount(), account)
            );

            Console.ReadKey();
        }
    }
}