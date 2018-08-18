using Vk.CSharp.Sdk.Internal.Attributes.Fields;

namespace Vk.CSharp.Sdk.Internal.Enums
{
    // Ссылка: https://vk.com/dev/errors

    internal enum Error
    {
        [FieldDescription("Произошла неизвестная ошибка.")]
        Unknown = 1,

        [FieldDescription("Приложение выключено.")]
        ApplicationIsOff = 2,

        [FieldDescription("Передан неизвестный метод.")]
        UnknownMethod = 3,

        [FieldDescription("Неверная подпись.")]
        InvalidSignature = 4,

        [FieldDescription("Авторизация пользователя не удалась.")]
        AuthorizationFailed = 5,

        [FieldDescription("Слишком много запросов в секунду.")]
        TooManyRequestsPerSecond = 6,

        [FieldDescription("Нет прав для выполнения этого действия.")]
        NoPermissionsToPerformThisAction = 7,

        [FieldDescription("Неверный запрос.")]
        InvalidRequest = 8,

        [FieldDescription("Слишком много однотипных действий.")]
        TooManySimilarActions = 9,

        [FieldDescription("Произошла внутренняя ошибка сервера.")]
        InternalServerError = 10,

        [FieldDescription("В тестовом режиме приложение должно быть выключено (пользователь залогинен).")]
        IncorrectTestMode = 11,

        [FieldDescription("Требуется ввод кода с картинки (Captcha).")]
        RequiredToEnterCaptcha = 14,

        [FieldDescription("Доступ запрещён.")]
        AccessIsDenied = 15,

        [FieldDescription("Требуется выполнение запросов по протоколу HTTPS.")]
        RequiredToPerformRequestsByHttps = 16,

        [FieldDescription("Требуется валидация пользователя.")]
        RequiredUserValidation = 17,

        [FieldDescription("Страница удалена или заблокирована.")]
        PageWasDeletedOrBlocked = 18,

        [FieldDescription("Данное действие запрещено для не Standalone приложений.")]
        ActionIsProhibitedForNonStandaloneApplications = 20,

        [FieldDescription("Данное действие разрешено только для Standalone и Open API приложений.")]
        ActionIsOnlyAllowedForStandaloneAndOpenApiApplications = 21,

        [FieldDescription("Метод был выключен.")]
        MethodWasDisabled = 23,

        [FieldDescription("Требуется подтверждение со стороны пользователя.")]
        RequiredConfirmationFromUser = 24,

        [FieldDescription("Ключ доступа сообщества недействителен.")]
        CommunityAccessTokenIsInvalid = 27,

        [FieldDescription("Ключ доступа приложения недействителен.")]
        ApplicationAccessTokenIsInvalid = 28,

        [FieldDescription("Достигнут количественный лимит на вызов метода.")]
        RateLimitReached = 29,

        [FieldDescription("Один из необходимых параметров был не передан или неверен.")]
        OneOfRequiredParametersWasNotTransmittedOrIncorrect = 100,

        [FieldDescription("Неверный идентификатор приложения.")]
        InvalidApplicationIdentifier = 101,

        [FieldDescription("Неверный идентификатор пользователя.")]
        InvalidUserIdentifier = 113,

        [FieldDescription("Неверный TimeStamp.")]
        InvalidTimeStamp = 150,

        [FieldDescription("Доступ к альбому запрещён.")]
        AccessToAlbumIsProhibited = 200,

        [FieldDescription("Доступ к аудио запрещён.")]
        AccessToAudioIsProhibited = 201,

        [FieldDescription("Доступ к группе запрещён.")]
        AccessToGroupIsProhibited = 203,

        [FieldDescription("Альбом переполнен.")]
        AlbumIsFull = 300
    }
}