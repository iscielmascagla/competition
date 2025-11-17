namespace Competition.Models
{
    using System;
    using System.Collections.Generic;

    namespace Competition.Models
    {
        public class Question
        {
            public string QuestionText { get; set; }  // Sorunun metni
            public List<string> Options { get; set; }  // Sorunun seçenekleri
            public int CorrectAnswerIndex { get; set; }  // Doğru cevabın seçenekler arasındaki indeks değeri

            public string BackgroundImage { get; set; } // Arka plan resmi
            public string CorrectAnswerVideoBlue { get; set; }
            public string CorrectAnswerVideoRed { get; set; }

            public  string UncorrectAnswerVideoBlue { get; set; }

            public string UncorrectAnswerVideoRed { get; set; }

            // Soru için ekstra metotlar veya özellikler eklemek isterseniz buraya yazabilirsiniz.
        }
    }

}
