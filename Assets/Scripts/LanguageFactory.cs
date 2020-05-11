using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace States
{
    public class LanguageFactory
    {
        private Language language { get; set; }
        public Language getLanguage(String lan)
        {
            if (lan == "english") {
                language = new EnglishStateFactory();
            } else if (lan == "spanish") {
                language = new SpanishStateFactory();
            }
            return language;
        }
    }
}
