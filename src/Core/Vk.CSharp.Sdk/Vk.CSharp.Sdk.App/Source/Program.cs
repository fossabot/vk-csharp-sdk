using System;
using Vk.CSharp.Sdk.External;

namespace Vk.CSharp.Sdk.App.Source
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine(
                VkApiProvider
                    .GetVkApi()
                    .GetEnvironment()
                    .Version
            );

            Console.ReadKey();
        }
    }
}