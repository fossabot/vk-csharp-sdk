using System;
using Vk.CSharp.Sdk.External;

namespace Vk.CSharp.Sdk.Core
{
    internal class VkApi : External.IVkApi
    {
        protected Random Random => new Random();

        public int GetRandomNumber()
        {
            return Random.Next();
        }
    }
}