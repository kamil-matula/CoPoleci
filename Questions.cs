﻿using System.Collections.Generic;

namespace CoPoleci
{
    class Questions
    {
        public static int Number { get; set; } = 0;
        public static List<string> questions = new List<string>
        {
            "Jak bardzo ważne jest dla Ciebie, \n aby film był śmieszny?",
            "Wolisz filmy fantastyczne \n czy realistyczne?",
            "Wolisz filmy starsze \n czy może nowsze?",
            "Czy podczas oglądania filmu \n lubisz się wzruszać?",
            "Wolisz lekkie czy może \n bardziej ambitne filmy?",
            "Czy lubisz filmy, w których \n występuje dużo akcji?",
            "Czy zależy Ci, aby film posiadał \n rozwinięty wątek romantyczny?",
            "Czy chcesz, aby w filmie \n było dużo muzyki?",
            "Czy zależy Ci na tym, aby film był \n dobrze oceniany przez krytyków?",
            "Czy lubisz się bać, \n gdy oglądasz filmy?"
        };
        public static List<string> leftEnds = new List<string> { "W ogóle", "Fantastyka", "Lata 40.", "Nie", "Lekkie", "Nie", "Nie", "Nie", "W ogóle", "W ogóle" };
        public static List<string> rightEnds = new List<string> { "Bardzo", "Realistyka", "2018+", "Tak", "Ambitne", "Tak", "Tak", "Najlepiej musical", "Bardzo", "Bardzo" };
        public static List<string> aboves = new List<string> { "", "", "1970        rok 2000            2010", "", "", "", "", "", "", "" };
    }
}