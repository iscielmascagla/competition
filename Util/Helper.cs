namespace Competition.Util
{
    public class Helper
    {
        public static void ResetQuiz()
        {
            QuizController.currentQuestionIndex = 0;
            QuizController.team1Score = 0;
            QuizController.team2Score = 0;
            QuizController.teamOrder = 1;
            QuizController.isAdsShowed = false;
            // Başlangıç sayfasına yönlendiriyoruz
        }



    }
}
