using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Typograph
{
    public class Rules
    {
        /// <summary>
        /// 1. Все знаки препинания пишутся слева слитно со словом, а справа отбиваются пробелом. 
        /// Тире отбивается пробелом с двух сторон. Скобки и кавычки пишутся слитно со словами, которые находятся внутри них.
        /// </summary>
        /// <param name="text">Текст, который будет отформотирован по правилу, описанном выше.</param>
        public static string FirstRule(string text)
        {
            Regex regexDash = new Regex(@"(\w)\s*-\s*(\w)", RegexOptions.Compiled);
            string spaceAroundDash = "$1 - $2";
            text = regexDash.Replace(text, spaceAroundDash);

            Regex regexBrackets = new Regex(@"(\()\s*(\w|\w.*\w)\s*(\))", RegexOptions.Compiled);
            string noSpaceInBrackets = "$1$2$3";
            text = regexBrackets.Replace(text, noSpaceInBrackets);

            Regex regexQuotes = new Regex(@"(\"")\s*(\w|\w.*\w)\s*(\"")", RegexOptions.Compiled);
            string noSpaceInQuotes = "$1$2$3";
            text = regexQuotes.Replace(text, noSpaceInQuotes);

            Regex regexPunctMark = new Regex(@"(\w+)(\s*)([,.!?;:…])", RegexOptions.Compiled);
            string spaceDeleter = "$1$3 ";
            text = regexPunctMark.Replace(text, spaceDeleter);

            return text;
        }

        /// <summary>
        /// 2. Нельзя писать подряд более одного пробела.
        /// </summary>
        /// <param name="text">Текст, который будет отформотирован по правилу, описанном выше.</param>
        public static string SecondRule(string text)
        {
            Regex regexMultipleSpaces = new Regex("[ ]+", RegexOptions.Compiled);
            string singleSpaceReplacement = " ";
            text = regexMultipleSpaces.Replace(text, singleSpaceReplacement);
            return text;
        }

        /// <summary>
        /// 6. Везде, где по правилам русского языка должно быть тире, ни в коем случае нельзя писать знак дефис, который по умолчанию доступен на клавиатуре. 
        /// Символ тире задаётся конструкцией —. 
        /// Например чтобы получить: «Книга — источник знания», нужно написать «Книга — источник знания».
        /// </summary>
        /// <param name="text">Текст, который будет отформотирован по правилу, описанном выше.</param>
        public static string SixthRule(string text)
        {
            Regex regexHyphenOnDash = new Regex(@"(\p{L})\s*-\s*(\p{L})", RegexOptions.Compiled);
            string replacementOnDash = "$1 — $2";
            text = regexHyphenOnDash.Replace(text, replacementOnDash);
            return text;
        }

        /// <summary>
        /// 13. Везде где имеется троеточие, его следует писать не тремя точками, а знаком … 
        /// Например: чтобы получить «Молчат… нет ответа…» нужно писать «Молчат… нет ответа…»
        /// </summary>
        /// <param name="text">Текст, который будет отформотирован по правилу, описанном выше.</param>
        public static string ThirteenthRule(string text)
        {
            Regex regexThreeDots = new Regex(@"\.{3}", RegexOptions.Compiled);
            string threeDotsReplacement = "…";
            text = regexThreeDots.Replace(text, threeDotsReplacement);
            return text;
        }

        /// <summary>
        /// Если выражение не заканчивается на точку, добавляет её в конце. 
        /// </summary>
        /// <param name="text">Текст, который будет отформотирован по правилу, описанном выше.</param>
        public static string FirstOwnRule(string text)
        {
            if (!text.EndsWith("."))
            {
                text += ".";
            }
            return text;
        }

        /// <summary>
        /// Учитывает неприемлимые слова и заменяет их на выражение *плохое слово*. 
        /// </summary>
        /// <param name="text">Текст, который будет отформотирован по правилу, описанном выше.</param>
        public static string SecondOwnRule(string text)
        {
            Regex regexCensorship = new Regex(@"(?i)черт|блин|урод|козел|козёл");
            string censorshipReplacement = "*плохое слово*";
            text = regexCensorship.Replace(text, censorshipReplacement);
            return text;
        }

        /// <summary>
        /// Выполняет все функции типографии этого приложения. 
        /// </summary>
        /// <param name="text">Текст, который будет отформотирован по всем правилам, описанным в это приложении.</param>
        public static string MainPart(string text)
        {
            text = ThirteenthRule(text);
            text = FirstRule(text);
            text = SecondRule(text);
            text = SixthRule(text);
            

            text = FirstOwnRule(text);
            text = SecondOwnRule(text);
            return text;
        }
    }
}
