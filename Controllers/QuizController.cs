using Competition.Models;
using Competition.Models.Competition.Models;
using Competition.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

public class QuizController : Controller
{
    public static int currentQuestionIndex = 0;  // Şu anki soru indeksi   
    public static int team1Score = 0;
    public static int team2Score = 0;
    public static int teamOrder = 1;
    public static bool isAdsShowed = false;


    [HttpGet]
    public IActionResult Start(string mode = "")
    {
        if (mode == "reset")
        { 
        Helper.ResetQuiz();
        }

        ViewBag.Team1Score = team1Score;
        ViewBag.Team2Score = team2Score;

       

     

            if ((currentQuestionIndex == 2 || currentQuestionIndex==5|| currentQuestionIndex == 8) && teamOrder==1&& !isAdsShowed)
            {

                isAdsShowed = true;
                return View("Ads");

            }
            else
            {
                isAdsShowed = false;
                if (teamOrder == 1)
                {
                    ViewBag.CurrentQuestion = QuizData.BlueQuestions[currentQuestionIndex];
                    ViewBag.CurrentQuestionIndex = currentQuestionIndex;
                    return View("BlueQuiz");
                }

                else
                {
                    ViewBag.CurrentQuestion = QuizData.RedQuestions[currentQuestionIndex];
                    ViewBag.CurrentQuestionIndex = currentQuestionIndex;
                    return View("RedQuiz");
                }


            }



        

        
       







    }

    [HttpPost]
    public IActionResult AnswerQuestion(int selectedOption)
    {
        Question currentQuestion = null;



        if (teamOrder == 1)
        {
            currentQuestion = QuizData.BlueQuestions[currentQuestionIndex];
            
        }
        else
        {
            currentQuestion = QuizData.RedQuestions[currentQuestionIndex];

            
            currentQuestionIndex++;
            

        }


        // Eğer doğru cevap verildiyse
        if (selectedOption == currentQuestion.CorrectAnswerIndex)
        {
          
           

            TempData["AnswerResult"] = "correct";  // Doğru cevap
            if (teamOrder == 1) // Blue team
            {
                team1Score++;
                ViewBag.CorrectAnswerVideo = currentQuestion.CorrectAnswerVideoBlue;
              
                

            }
            else // Red team
            {
                team2Score++;
                ViewBag.CorrectAnswerVideo = currentQuestion.CorrectAnswerVideoRed;
          

            

            }

        }
        else
        {
            TempData["AnswerResult"] = "incorrect";  // Yanlış cevap
            if (teamOrder == 1) // Blue team
            {
                
                ViewBag.UncorrectAnswerVideo = currentQuestion.UncorrectAnswerVideoBlue;
            }
            else // Red team
            {
                
                ViewBag.UncorrectAnswerVideo = currentQuestion.UncorrectAnswerVideoRed;
            }



        }
        if (teamOrder == 1)
        {
            
            teamOrder = 2;
        }
        else
        {
            
            teamOrder = 1;
            

        }



        // Eğer 10 soru tamamlandıysa, yarışmayı sonlandırıyoruz
        if (currentQuestionIndex >= 7 && team1Score != team2Score && teamOrder == 1)
        {

            return RedirectToAction("Results");
        }

        if (currentQuestionIndex == 7 && team1Score == team2Score && teamOrder == 1)
        { 
        return RedirectToAction("ShowTie");
        }


        if (currentQuestionIndex >=9 &&  teamOrder == 1)
        {

            return RedirectToAction("Results");

        }



        return RedirectToAction("Start");
    }


    public IActionResult Results()
    {


        ViewBag.Team1Score = team1Score;
        ViewBag.Team2Score = team2Score;


        
        // Sonuçları gösteren view'a yönlendiriyoruz
        return View();
    }

    public IActionResult ShowWinner()
    {
        ViewBag.Team1Score = team1Score;
        ViewBag.Team2Score = team2Score;
        Helper.ResetQuiz();
        return View();


    }
    public IActionResult ShowTie()
    {
        ViewBag.Team1Score = team1Score;
        ViewBag.Team2Score = team2Score;
        // Reklamları gösteren view'a yönlendiriyoruz
        return View();
    }


    public IActionResult Reset()
    {
        // Yarışmayı sıfırlıyoruz       
        return RedirectToAction("FirstPage","Home");
    }
}