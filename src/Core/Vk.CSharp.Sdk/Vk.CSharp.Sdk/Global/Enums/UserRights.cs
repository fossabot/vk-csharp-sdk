using System;
using Vk.CSharp.Sdk.Internal.Attributes.Fields;

namespace Vk.CSharp.Sdk.Global.Enums
{
    // Ссылка: https://vk.com/dev/permissions

    /// <summary>
    /// Права доступа для токена пользователя.
    /// </summary>
    [Flags]
    public enum UserRights
    {
        /// <summary>
        /// Пользователь разрешил отправлять ему уведомления.
        /// </summary>
        [FieldValue("notify")]
        Notify = 1,

        /// <summary>
        /// Доступ к друзьям.
        /// </summary>
        [FieldValue("friends")]
        Friends = 2,

        /// <summary>
        /// Доступ к фотографиям.
        /// </summary>
        [FieldValue("photos")]
        Photos = 4,

        /// <summary>
        /// Доступ к аудиозаписям.
        /// </summary>
        [FieldValue("audio")]
        Audio = 8,

        /// <summary>
        /// Доступ к видеозаписям.
        /// </summary>
        [FieldValue("video")]
        Video = 16,

        /// <summary>
        /// Доступ к историям.
        /// </summary>
        [FieldValue("stories")]
        Stories = 64,

        /// <summary>
        /// Доступ к вики-страницам.
        /// </summary>
        [FieldValue("pages")]
        Pages = 128,

        /// <summary>
        /// Добавление ссылки на приложение в меню слева.
        /// </summary>
        [FieldValue("link_control")]
        LinkControl = 256,

        /// <summary>
        /// Доступ к статусу пользователя.
        /// </summary>
        [FieldValue("status")]
        Status = 1024,

        /// <summary>
        /// Доступ к заметкам пользователя.
        /// </summary>
        [FieldValue("notes")]
        Notes = 2048,

        /// <summary>
        /// Доступ к расширенным методам работы с сообщениями (только для Standalone-приложений).
        /// </summary>
        [FieldValue("messages")]
        Messages = 4096,

        /// <summary>
        /// Доступ к обычным и расширенным методам работы со стеной.
        /// </summary>
        [FieldValue("wall")]
        Wall = 8192,

        /// <summary>
        /// Доступ к расширенным методам работы с рекламным API.
        /// </summary>
        [FieldValue("ads")]
        Ads = 32768,

        /// <summary>
        /// Доступ к API в любое время.
        /// </summary>
        [FieldValue("offline")]
        Offline = 65536,

        /// <summary>
        /// Доступ к документам.
        /// </summary>
        [FieldValue("docs")]
        Docs = 131072,

        /// <summary>
        /// Доступ к группам пользователя.
        /// </summary>
        [FieldValue("groups")]
        Groups = 262144,

        /// <summary>
        /// Доступ к оповещениям об ответах пользователю.
        /// </summary>
        [FieldValue("notofications")]
        Notifications = 524288,

        /// <summary>
        /// Доступ к статистике групп и приложений пользователя, администратором которых он является.
        /// </summary>
        [FieldValue("stats")]
        Stats = 1048576,

        /// <summary>
        /// Доступ к почте пользователя.
        /// </summary>
        [FieldValue("email")]
        Email = 4194304,

        /// <summary>
        /// Доступ к товарам.
        /// </summary>
        [FieldValue("market")]
        Market = 134217728,

        /// <summary>
        /// Все.
        /// </summary>
        [FieldValue("all")]
        All = Notify
            | Friends
            | Photos
            | Audio
            | Video
            | Stories
            | Pages
            | LinkControl
            | Status
            | Notes
            | Messages
            | Wall
            | Ads
            | Offline
            | Docs
            | Groups
            | Notifications
            | Stats
            | Email
            | Market
    }
}