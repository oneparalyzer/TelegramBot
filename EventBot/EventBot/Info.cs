using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBot
{
    internal static class Info
    {
        public static string GetHello { get; } = "Приветствуем участников XVI регионального " +
                                                 "торгового Форума «Потребительский рынок " +
                                                 "Архангельской области - ПЕРЕЗАГРУЗКА 2022 года» " +
                                                 "24-25 ноября 2022 г.";
        public static string GetLocation { get; } = "г. Архангельск «Норд Экспо», ул. Папанина, 25, " +
                                                    "округ Варавино-Фактория.";
        public static string GetLocationUrl { get; } = "https://torgforum29.ru/#rec501112985";
        public static string GetUrlProgram { get; } = "https://torgforum29.ru/#rec369777312";
        public static string GetUrlSpeakers { get; } = "https://torgforum29.ru/#rec369123628";
        public static string GetUrlProgramDoc { get; } = "https://docs.google.com/document/d/1K9GEh1YNaongsEwz2QbZcySVhCzt9cXa/edit?usp=sharing&ouid=116302579545141293788&rtpof=true&sd=true";
    }
}
