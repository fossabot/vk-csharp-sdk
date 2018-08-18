using Vk.CSharp.Sdk.External;
using Vk.CSharp.Sdk.Global.Models;
using Vk.CSharp.Sdk.Internal.Enums;
using Vk.CSharp.Sdk.Internal.Extensions;

namespace Vk.CSharp.Sdk.Internal
{
    internal abstract class Core : IEnvironment
    {
        protected Environment Environment { get; set; }

        /// <summary>
        /// Текущая версия API ВКонтакте.
        /// </summary>
        protected static Version CurrentVersion => Version.V580;

        protected Core()
        {
            InitEnvironment();
        }

        public Environment GetEnvironment()
        {
            return Environment;
        }

        private void InitEnvironment()
        {
            Environment = new Environment
            {
                Version = CurrentVersion.GetStringValue()
            };
        }
    }
}