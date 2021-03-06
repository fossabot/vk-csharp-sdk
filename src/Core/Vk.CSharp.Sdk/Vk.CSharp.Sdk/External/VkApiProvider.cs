﻿using System;
using Vk.CSharp.Sdk.Internal;
using Vk.CSharp.Sdk.External.Modules;
using Vk.CSharp.Sdk.Global.Models;
using Vk.CSharp.Sdk.Internal.Modules;
using Environment = Vk.CSharp.Sdk.Global.Models.Environment;

namespace Vk.CSharp.Sdk.External
{
    /// <summary>
    /// Провайдер API ВКонтакте.
    /// </summary>
    public static class VkApiProvider
    {
        private static readonly Lazy<IVkApi> LazyVkApi =
            new Lazy<IVkApi>(() => new VkApi());

        private static readonly Lazy<IAccount> LazyAccount =
            new Lazy<IAccount>(() => new Account());

        private static readonly Lazy<IAds> LazyAds =
            new Lazy<IAds>(() => new Ads());

        private static readonly Lazy<IMessages> LazyMessages =
            new Lazy<IMessages>(() => new Messages());

        private static readonly Lazy<IWall> LazyWall =
            new Lazy<IWall>(() => new Wall());

        private static readonly Lazy<IEnvironmentProvider> LazyEnvironmentProvider =
            new Lazy<IEnvironmentProvider>(() => new EnvironmentProvider());

        /// <summary>
        /// Выполняет авторизацию.
        /// </summary>
        /// <param name="data">Данные для авторизации.</param>
        /// <returns>Результат авторизации.</returns>
        public static AuthorizationResult Authorize(AuthorizationData data) => GetVkApi().Authorize(data);

        /// <summary>
        /// Выполняет деавторизацию (будет очищено окружение).
        /// </summary>
        public static void Deauthorize() => GetVkApi().Deauthorize();

        /// <summary>
        /// Возвращает окружение.
        /// </summary>
        /// <returns>Окружение.</returns>
        public static Environment GetEnvironment() => GetEnvironmentProvider().GetEnvironment();

        /// <summary>
        /// Возвращает интерфейс провайдера окружения.
        /// </summary>
        /// <returns>Интерфейс провайдера окружения.</returns>
        public static IEnvironmentProvider GetEnvironmentProvider() => LazyEnvironmentProvider.Value;

        /// <summary>
        /// Возвращает интерфейс для работы с API ВКонтакте.
        /// </summary>
        /// <returns>Интерфейс для взаимодействия с API ВКонтакте.</returns>
        public static IVkApi GetVkApi() => LazyVkApi.Value;

        /// <summary>
        /// Возвращает интерфейс для работы с аккаунтом.
        /// </summary>
        /// <returns>Интерфейс для работы с аккаунтом.</returns>
        public static IAccount GetAccount() => LazyAccount.Value;

        /// <summary>
        /// Возвращает интерфейс для работы с рекламным кабинетом.
        /// </summary>
        /// <returns>Интерфейс для работы с рекламным кабинетом.</returns>
        public static IAds GetAds() => LazyAds.Value;

        /// <summary>
        /// Возвращает интерфейс для работы с личными сообщениями.
        /// </summary>
        /// <returns>Интерфейс для работы с личными сообщениями.</returns>
        public static IMessages GetMessages() => LazyMessages.Value;

        /// <summary>
        /// Возвращает интерфейс для работы с записями на стене.
        /// </summary>
        /// <returns>Интерфейс для работы с записями на стене.</returns>
        public static IWall GetWall() => LazyWall.Value;
    }
}