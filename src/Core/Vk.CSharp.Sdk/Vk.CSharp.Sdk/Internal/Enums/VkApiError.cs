using Vk.CSharp.Sdk.Internal.Attributes;

namespace Vk.CSharp.Sdk.Internal.Enums
{
    /// <summary>
    /// Ошибка API ВКонтакте.
    /// </summary>
    internal enum VkApiError
    {
        /// <summary>
        /// Произошла неизвестная ошибка.
        /// </summary>
        [FieldDescription("Произошла неизвестная ошибка.")]
        Unknown = 1,

        /// <summary>
        /// Приложение выключено.
        /// </summary>
        [FieldDescription("Приложение выключено.")]
        ApplicationIsOff = 2,

        /// <summary>
        /// Передан неизвестный метод.
        /// </summary>
        [FieldDescription("Передан неизвестный метод.")]
        UnknownMethod = 3,

        /// <summary>
        /// Неверная подпись.
        /// </summary>
        [FieldDescription("Неверная подпись.")]
        InvalidSignature = 4,

        /// <summary>
        /// Авторизация пользователя не удалась.
        /// </summary>
        [FieldDescription("Авторизация пользователя не удалась.")]
        AuthorizationFailed = 5,

        /// <summary>
        /// Слишком много запросов в секунду.
        /// </summary>
        [FieldDescription("Слишком много запросов в секунду.")]
        TooManyRequestsPerSecond = 6,

        /// <summary>
        /// Нет прав для выполнения этого действия.
        /// </summary>
        [FieldDescription("Нет прав для выполнения этого действия.")]
        NoPermissionsToPerformThisAction = 7,

        /// <summary>
        /// Неверный запрос.
        /// </summary>
        [FieldDescription("Неверный запрос.")]
        InvalidRequest = 8,

        /// <summary>
        /// Слишком много однотипных действий.
        /// </summary>
        [FieldDescription("Слишком много однотипных действий.")]
        TooManySimilarActions = 9,

        /// <summary>
        /// Произошла внутренняя ошибка сервера.
        /// </summary>
        [FieldDescription("Произошла внутренняя ошибка сервера.")]
        InternalServerError = 10,

        /// <summary>
        /// В тестовом режиме приложение должно быть выключено или пользователь должен быть залогинен.
        /// </summary>
        [FieldDescription("В тестовом режиме приложение должно быть выключено (пользователь залогинен).")]
        IncorrectTestMode = 11,

        /// <summary>
        /// Требуется ввод кода с картинки (Captcha).
        /// </summary>
        [FieldDescription("Требуется ввод кода с картинки (Captcha).")]
        RequiredToEnterCaptcha = 14,

        /// <summary>
        /// Доступ запрещён.
        /// </summary>
        [FieldDescription("Доступ запрещён.")]
        AccessIsDenied = 15,

        /// <summary>
        /// Требуется выполнение запросов по протоколу HTTPS,
        /// так как пользователь включил настройку,
        /// требующую работу через безопасное соединение.
        /// </summary>
        [FieldDescription("Требуется выполнение запросов по протоколу HTTPS.")]
        RequiredToPerformRequestsByHttps = 16,

        /// <summary>
        /// Требуется валидация пользователя.
        /// </summary>
        [FieldDescription("Требуется валидация пользователя.")]
        RequiredUserValidation = 17,

        /// <summary>
        /// Страница удалена или заблокирована.
        /// </summary>
        [FieldDescription("Страница удалена или заблокирована.")]
        PageWasDeletedOrBlocked = 18,

        /// <summary>
        /// Данное действие запрещено для не Standalone приложений.
        /// </summary>
        [FieldDescription("Данное действие запрещено для не Standalone приложений.")]
        ActionIsProhibitedForNonStandaloneApplications = 20,

        /// <summary>
        /// Данное действие разрешено только для Standalone и Open API приложений.
        /// </summary>
        [FieldDescription("Данное действие разрешено только для Standalone и Open API приложений.")]
        ActionIsOnlyAllowedForStandaloneAndOpenApiApplications = 21,

        /// <summary>
        /// Метод был выключен. 
        /// </summary>
        [FieldDescription("Метод был выключен.")]
        MethodWasDisabled = 23,

        /// <summary>
        /// Требуется подтверждение со стороны пользователя.
        /// </summary>
        [FieldDescription("Требуется подтверждение со стороны пользователя.")]
        RequiredConfirmationFromUser = 24,

        /// <summary>
        /// Ключ доступа сообщества недействителен.
        /// </summary>
        [FieldDescription("Ключ доступа сообщества недействителен.")]
        CommunityAccessTokenIsInvalid = 27,

        /// <summary>
        /// Ключ доступа приложения недействителен.
        /// </summary>
        [FieldDescription("Ключ доступа приложения недействителен.")]
        ApplicationAccessTokenIsInvalid = 28,

        /// <summary>
        /// Достигнут количественный лимит на вызов метода.
        /// </summary>
        [FieldDescription("Достигнут количественный лимит на вызов метода.")]
        RateLimitReached = 29,

        /// <summary>
        /// Один из необходимых параметров был не передан или неверен.
        /// </summary>
        [FieldDescription("Один из необходимых параметров был не передан или неверен.")]
        OneOfRequiredParametersWasNotTransmittedOrIncorrect = 100,

        /// <summary>
        /// Неверный идентификатор приложения.
        /// </summary>
        [FieldDescription("Неверный идентификатор приложения.")]
        InvalidApplicationIdentifier = 101,

        /// <summary>
        /// Неверный идентификатор пользователя.
        /// </summary>
        [FieldDescription("Неверный идентификатор пользователя.")]
        InvalidUserIdentifier = 113,

        /// <summary>
        /// Неверный TimeStamp.
        /// </summary>
        [FieldDescription("Неверный TimeStamp.")]
        InvalidTimeStamp = 150,

        /// <summary>
        /// Доступ к альбому запрещён.
        /// </summary>
        [FieldDescription("Доступ к альбому запрещён.")]
        AccessToAlbumIsProhibited = 200,

        /// <summary>
        /// Доступ к аудио запрещён.
        /// </summary>
        [FieldDescription("Доступ к аудио запрещён.")]
        AccessToAudioIsProhibited = 201,

        /// <summary>
        /// Доступ к группе запрещён.
        /// </summary>
        [FieldDescription("Доступ к группе запрещён.")]
        AccessToGroupIsProhibited = 203,

        /// <summary>
        /// Альбом переполнен.
        /// </summary>
        [FieldDescription("Альбом переполнен.")]
        AlbumIsFull = 300

        // TODO: Добавить остальные ошибки.

        // [500] Действие запрещено. Вы должны включить переводы голосов в настройках приложения.
        // [600] Нет прав на выполнение данных операций с рекламным кабинетом.
        // [603] Произошла ошибка при работе с рекламным кабинетом.
    }
}