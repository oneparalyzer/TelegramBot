using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;

namespace EventBot
{
    internal static class Keyboards
    {
        internal static IReplyMarkup? GetBaseKeyboard()
        {
            InlineKeyboardMarkup inlineKeyboard = new(new[]
            {
                new []
                {
                    InlineKeyboardButton.WithCallbackData(
                        text: "Место проведения",
                        callbackData: "Location")
                },
                new []
                {
                    InlineKeyboardButton.WithUrl(
                        text: "Скачать программу форума",
                        url: Info.GetUrlProgramDoc)
                },
                new []
                {
                    InlineKeyboardButton.WithUrl(
                        text: "Программа форума",
                        url: Info.GetUrlProgram)
                },
                new []
                {
                    InlineKeyboardButton.WithUrl(
                        text: "Спикеры форума",
                        url: Info.GetUrlSpeakers)
                }
            });
            return inlineKeyboard;
        }

        internal static IReplyMarkup? GetLocationKeyboard()
        {
            InlineKeyboardMarkup inlineKeyboard = new(new[]
            {
                new []
                {
                    InlineKeyboardButton.WithUrl(
                        text: "Место проведения",
                        url: Info.GetLocationUrl)
                }
            });
            return inlineKeyboard;
        }
    }
}
