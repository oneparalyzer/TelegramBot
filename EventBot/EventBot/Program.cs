using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InputFiles;

namespace EventBot
{
    class Program
    {
        #region Уникальный ключ телеграм бота
        private static readonly string token = "Telegram-token";
        #endregion

        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            TelegramBotClient telegramBot = new(token);
            telegramBot.StartReceiving(UpdateHandler, ExceptionHandler);
            Console.ReadLine();
        }

        /// <summary>
        /// Метод для обработки обновлений (приходящих сообщений)
        /// </summary>
        /// <param name="bot"></param>
        /// <param name="update"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        private async static Task UpdateHandler(ITelegramBotClient bot, Update update, CancellationToken token)
        {
            #region Тип обратного вызова
            if (update?.Type == UpdateType.CallbackQuery)
            {
                var callBackMsg = update?.CallbackQuery?.Data;
                var callBackId = update?.CallbackQuery?.Message?.Chat.Id;

                if (callBackMsg != null)
                {
                    if (callBackMsg.StartsWith("Location"))
                    {
                        await bot.SendTextMessageAsync(chatId: callBackId,
                                                       text: Info.GetLocation,
                                                       replyMarkup: Keyboards.GetLocationKeyboard());
                    }
                }
                return;
            }
            #endregion

            #region Тип обычного сообщения
            if (update?.Type == UpdateType.Message)
            {
                var msg = update?.Message?.Text;
                var id = update?.Message?.Chat.Id;

                if (msg != null)
                {
                    if (msg == "/start")
                    {
                        #region Отправка сообщения
                        await bot.SendTextMessageAsync(
                                chatId: id,
                                text: Info.GetHello,
                                replyMarkup: Keyboards.GetBaseKeyboard());
                        #endregion

                        return;
                    }
                    return;
                }
            }
            #endregion
        }

        /// <summary>
        /// Метод для обработки ошибок
        /// </summary>
        /// <param name="bot"></param>
        /// <param name="ex"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private static Task ExceptionHandler(ITelegramBotClient bot, Exception ex, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}
