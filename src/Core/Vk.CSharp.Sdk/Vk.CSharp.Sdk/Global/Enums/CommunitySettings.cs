using System;
using Vk.CSharp.Sdk.Internal.Attributes.Fields;

namespace Vk.CSharp.Sdk.Global.Enums
{
    // Ссылка: https://vk.com/dev/permissions

    /// <summary>
    /// Права доступа для токена сообщества.
    /// </summary>
    [Flags]
    public enum CommunitySettings
    {
        /// <summary>
        /// Доступ к историям.
        /// </summary>
        [FieldValue("stories")]
        Stories = 1,

        /// <summary>
        /// Доступ к фотографиям.
        /// </summary>
        [FieldValue("photos")]
        Photos = 4,

        /// <summary>
        /// Доступ к виджетам приложений сообществ.
        /// </summary>
        [FieldValue("app_widget")]
        AppWidget = 64,

        /// <summary>
        /// Доступ к сообщениям сообщества.
        /// </summary>
        [FieldValue("messages")]
        Messages = 4096,

        /// <summary>
        /// Доступ к документам.
        /// </summary>
        [FieldValue("docs")]
        Docs = 131072,

        /// <summary>
        /// Доступ к администрированию сообщества.
        /// </summary>
        [FieldValue("manage")]
        Manage = 262144,

        /// <summary>
        /// Все.
        /// </summary>
        [FieldValue("all")]
        All = Stories
            | Photos
            | AppWidget
            | Messages
            | Docs
            | Manage
    }
}