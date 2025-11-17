using Competition.Models;
using Competition.Models.Competition.Models;
using static System.Net.WebRequestMethods;

public static class QuizData
{
    public static List<Question> BlueQuestions = new List<Question>
    {

        new Question
        {
            QuestionText = "",
            Options = new List<string> {"","", "", "" },
            CorrectAnswerIndex = 3,
            CorrectAnswerVideoBlue= "https://res.cloudinary.com/doadpcnld/video/upload/v1744462225/Mavi-10_eufqtv.mp4",
            UncorrectAnswerVideoBlue="https://res.cloudinary.com/doadpcnld/video/upload/v1744462464/Mavi_ka%C3%A7an-1_midukc.mp4",
            BackgroundImage="https://res.cloudinary.com/doadpcnld/image/upload/q_auto:eco/v1744482809/FI%CC%87NAL_EKRANLAR-SORU_EKRANI_ACTIVE_Dinamo_1-100-min_pdvo6g.jpg"
        },
        new Question
        {
            QuestionText = "",
            Options = new List<string> {"","", "", "" },
            CorrectAnswerIndex = 2,
            CorrectAnswerVideoBlue= "https://res.cloudinary.com/doadpcnld/video/upload/v1744462129/Mavi-2_ofrip6.mp4",
            UncorrectAnswerVideoBlue="https://res.cloudinary.com/doadpcnld/video/upload/v1744462481/Mavi_ka%C3%A7an-2_h5l8fi.mp4",
            BackgroundImage="https://res.cloudinary.com/doadpcnld/image/upload/q_auto:eco/v1744482805/FI%CC%87NAL_EKRANLAR-SORU_EKRANI_ACTIVE_Dinamo_2-100-min_mffdvi.jpg"
        },
        new Question
        {
            QuestionText = "",
            Options = new List<string> {"","", "", "" },
            CorrectAnswerIndex = 2,
            CorrectAnswerVideoBlue= "https://res.cloudinary.com/doadpcnld/video/upload/v1744462229/Mavi-3_d9kikv.mp4",
            UncorrectAnswerVideoBlue="https://res.cloudinary.com/doadpcnld/video/upload/v1744462456/Mavi_ka%C3%A7an-3_iylng0.mp4",
            BackgroundImage="https://res.cloudinary.com/doadpcnld/image/upload/q_auto:eco/v1744482815/FI%CC%87NAL_EKRANLAR-SORU_EKRANI_ACTIVE_Dinamo_3-100-min_cbbxqf.jpg"
        },
        new Question
        {
            QuestionText = "",
            Options = new List<string> {"","", "", "" },
            CorrectAnswerIndex = 0,
            CorrectAnswerVideoBlue= "https://res.cloudinary.com/doadpcnld/video/upload/v1744462185/Mavi-4_ybdd9f.mp4",
             UncorrectAnswerVideoBlue="https://res.cloudinary.com/doadpcnld/video/upload/v1744462480/Mavi_ka%C3%A7an-4_zxdgdw.mp4",
             BackgroundImage="https://res.cloudinary.com/doadpcnld/image/upload/q_auto:eco/v1744482812/FI%CC%87NAL_EKRANLAR-SORU_EKRANI_ACTIVE_Dinamo_4-100-min_zrw5dk.jpg"
        },
        new Question
        {
           QuestionText = "",
            Options = new List<string> {"","", "", "" },
            CorrectAnswerIndex = 1,
            CorrectAnswerVideoBlue= "https://res.cloudinary.com/doadpcnld/video/upload/v1744462185/Mavi-5_pbgshb.mp4",
            UncorrectAnswerVideoBlue="https://res.cloudinary.com/doadpcnld/video/upload/v1744462473/Mavi_ka%C3%A7an-5_arzmv4.mp4",
            BackgroundImage="https://res.cloudinary.com/doadpcnld/image/upload/q_auto:eco/v1744482803/FI%CC%87NAL_EKRANLAR-SORU_EKRANI_ACTIVE_Dinamo_5-100-min_kjpc20.jpg"
        },
        new Question
        {
            QuestionText = "",
            Options = new List<string> {"","", "", "" },
            CorrectAnswerIndex = 1,
            CorrectAnswerVideoBlue= "https://res.cloudinary.com/doadpcnld/video/upload/v1744462135/Mavi-6_u9p1rf.mp4",
            UncorrectAnswerVideoBlue="https://res.cloudinary.com/doadpcnld/video/upload/v1744462484/Mavi_ka%C3%A7an-6_ovk7tp.mp4",
            BackgroundImage="https://res.cloudinary.com/doadpcnld/image/upload/q_auto:eco/v1744482804/FI%CC%87NAL_EKRANLAR-SORU_EKRANI_ACTIVE_Dinamo_6-100-min_fbidcq.jpg"
        },

        new Question
        {
            QuestionText = "",
            Options = new List<string> {"","", "", "" },
            CorrectAnswerIndex = 1,
            CorrectAnswerVideoBlue= "https://res.cloudinary.com/doadpcnld/video/upload/v1744462232/Mavi-7_y80zrl.mp4",
            UncorrectAnswerVideoBlue="https://res.cloudinary.com/doadpcnld/video/upload/v1744462518/Mavi_ka%C3%A7an-7_asbr31.mp4",
            BackgroundImage="https://res.cloudinary.com/doadpcnld/image/upload/q_auto:eco/v1744482817/FI%CC%87NAL_EKRANLAR-SORU_EKRANI_ACTIVE_Dinamo_7-100-min_fyfa8b.jpg"
        },

        new Question
        {
            QuestionText = "",
            Options = new List<string> {"","", "", "" },
            CorrectAnswerIndex = 2,
            CorrectAnswerVideoBlue= "https://res.cloudinary.com/doadpcnld/video/upload/v1744462231/Mavi-8_eozbj7.mp4",
            UncorrectAnswerVideoBlue="https://res.cloudinary.com/doadpcnld/video/upload/v1744462501/Mavi_ka%C3%A7an-8_irpqeg.mp4",
            BackgroundImage="https://res.cloudinary.com/doadpcnld/image/upload/q_auto:eco/v1744482815/FI%CC%87NAL_EKRANLAR-SORU_EKRANI_ACTIVE_Dinamo_8-100-min_udopax.jpg"
        },
        new Question
        {
           QuestionText = "",
            Options = new List<string> {"","", "", "" },
            CorrectAnswerIndex = 2,
            CorrectAnswerVideoBlue= "https://res.cloudinary.com/doadpcnld/video/upload/v1744462184/Mavi-9_y5dmpf.mp4",
            UncorrectAnswerVideoBlue="https://res.cloudinary.com/doadpcnld/video/upload/v1744462509/Mavi_ka%C3%A7an-9_aw9sqg.mp4",
            BackgroundImage="https://res.cloudinary.com/doadpcnld/image/upload/q_auto:eco/v1744482819/FI%CC%87NAL_EKRANLAR-SORU_EKRANI_ACTIVE_Dinamo-100-min_r64kpn.jpg"
        }


    };
    public static List<Question> RedQuestions = new List<Question>
    {
        
        new Question
        {
            QuestionText = "",
            Options = new List<string> {"","", "", "" },
            CorrectAnswerIndex = 1,
             CorrectAnswerVideoRed= "https://res.cloudinary.com/doadpcnld/video/upload/v1744462037/K%C4%B1rm%C4%B1z%C4%B1-10_vqj5np.mp4",
             UncorrectAnswerVideoRed="https://res.cloudinary.com/doadpcnld/video/upload/v1744462311/K%C4%B1rm%C4%B1z%C4%B1_ka%C3%A7an-1_r03pto.mp4",
             BackgroundImage="https://res.cloudinary.com/doadpcnld/image/upload/q_auto:eco/v1744482936/FI%CC%87NAL_EKRANLAR-SORU_EKRANI_Sangro_FC_1-100-min_n1vmky.jpg"
        },
        new Question
        {
             QuestionText = "",
            Options = new List<string> {"","", "", "" },
            CorrectAnswerIndex = 1,
            CorrectAnswerVideoRed= "https://res.cloudinary.com/doadpcnld/video/upload/v1744462037/K%C4%B1rm%C4%B1z%C4%B1-2_ubxdjn.mp4",
            UncorrectAnswerVideoRed="https://res.cloudinary.com/doadpcnld/video/upload/v1744462327/K%C4%B1rm%C4%B1z%C4%B1_ka%C3%A7an-2_b2iosn.mp4",
            BackgroundImage="https://res.cloudinary.com/doadpcnld/image/upload/q_auto:eco/v1744482937/FI%CC%87NAL_EKRANLAR-SORU_EKRANI_Sangro_FC_2-100-min_e8ebcf.jpg"
        },
        new Question
        {
             QuestionText = "",
            Options = new List<string> {"","", "", "" },
            CorrectAnswerIndex = 0,
            CorrectAnswerVideoRed= "https://res.cloudinary.com/doadpcnld/video/upload/v1744462005/K%C4%B1rm%C4%B1z%C4%B1-3_nssqto.mp4",
            UncorrectAnswerVideoRed="https://res.cloudinary.com/doadpcnld/video/upload/v1744462326/K%C4%B1rm%C4%B1z%C4%B1_ka%C3%A7an-3_v0epvg.mp4",
            BackgroundImage="https://res.cloudinary.com/doadpcnld/image/upload/q_auto:eco/v1744482941/FI%CC%87NAL_EKRANLAR-SORU_EKRANI_Sangro_FC_3-100-min_wgmtvb.jpg"
        },
        new Question
        {
             QuestionText = "",
            Options = new List<string> {"","", "", "" },
            CorrectAnswerIndex = 2,
            CorrectAnswerVideoRed= "https://res.cloudinary.com/doadpcnld/video/upload/v1744461995/K%C4%B1rm%C4%B1z%C4%B1-4_dktnl8.mp4",
            UncorrectAnswerVideoRed="https://res.cloudinary.com/doadpcnld/video/upload/v1744462309/K%C4%B1rm%C4%B1z%C4%B1_ka%C3%A7an-4_xzl0m3.mp4",
            BackgroundImage="https://res.cloudinary.com/doadpcnld/image/upload/q_auto:eco/v1744482935/FI%CC%87NAL_EKRANLAR-SORU_EKRANI_Sangro_FC_4-100-min_bzrklh.jpg"
        },
        new Question
        {
             QuestionText = "",
            Options = new List<string> {"","", "", "" },
            CorrectAnswerIndex = 1,
            CorrectAnswerVideoRed= "https://res.cloudinary.com/doadpcnld/video/upload/v1744461937/K%C4%B1rm%C4%B1z%C4%B1-5_hek9tn.mp4",
            UncorrectAnswerVideoRed="https://res.cloudinary.com/doadpcnld/video/upload/v1744462366/K%C4%B1rm%C4%B1z%C4%B1_ka%C3%A7an-5_xuca6y.mp4",
            BackgroundImage="https://res.cloudinary.com/doadpcnld/image/upload/q_auto:eco/v1744482931/FI%CC%87NAL_EKRANLAR-SORU_EKRANI_Sangro_FC_5-100-min_huzdcm.jpg"
        },

        new Question
        {
            QuestionText = "",
            Options = new List<string> {"","", "", "" },
            CorrectAnswerIndex = 1,
            CorrectAnswerVideoRed= "https://res.cloudinary.com/doadpcnld/video/upload/v1744461979/K%C4%B1rm%C4%B1z%C4%B1-6_m6gqkv.mp4",
            UncorrectAnswerVideoRed="https://res.cloudinary.com/doadpcnld/video/upload/v1744462374/K%C4%B1rm%C4%B1z%C4%B1_ka%C3%A7an-6_p7qmqg.mp4",
            BackgroundImage="https://res.cloudinary.com/doadpcnld/image/upload/q_auto:eco/v1744482933/FI%CC%87NAL_EKRANLAR-SORU_EKRANI_Sangro_FC_6-100-min_xsmpsc.jpg"
        },
        new Question
        {
             QuestionText = "",
            Options = new List<string> {"","", "", "" },
            CorrectAnswerIndex = 0,
            CorrectAnswerVideoRed= "https://res.cloudinary.com/doadpcnld/video/upload/v1744461936/K%C4%B1rm%C4%B1z%C4%B1-7_omynqq.mp4",
            UncorrectAnswerVideoRed="https://res.cloudinary.com/doadpcnld/video/upload/v1744462352/K%C4%B1rm%C4%B1z%C4%B1_ka%C3%A7an-7_ygwete.mp4",
            BackgroundImage="https://res.cloudinary.com/doadpcnld/image/upload/q_auto:eco/v1744482942/FI%CC%87NAL_EKRANLAR-SORU_EKRANI_Sangro_FC_7-100-min_yak8dp.jpg"
        },
        new Question
        {
             QuestionText = "",
            Options = new List<string> {"","", "", "" },
            CorrectAnswerIndex = 2,
            CorrectAnswerVideoRed= "https://res.cloudinary.com/doadpcnld/video/upload/v1744462049/K%C4%B1rm%C4%B1z%C4%B1-8_qdzbna.mp4",
            UncorrectAnswerVideoRed="https://res.cloudinary.com/doadpcnld/video/upload/v1744462359/K%C4%B1rm%C4%B1z%C4%B1_ka%C3%A7an-8_ixdaf5.mp4",
            BackgroundImage="https://res.cloudinary.com/doadpcnld/image/upload/q_auto:eco/v1744482940/FI%CC%87NAL_EKRANLAR-SORU_EKRANI_Sangro_FC_8-100-min_w1ozis.jpg"
        },
        new Question
        {
             QuestionText = "",
            Options = new List<string> {"","", "", "" },
            CorrectAnswerIndex = 1,
            CorrectAnswerVideoRed= "https://res.cloudinary.com/doadpcnld/video/upload/v1744461994/K%C4%B1rm%C4%B1z%C4%B1-9_tz2s9j.mp4",
            UncorrectAnswerVideoRed="https://res.cloudinary.com/doadpcnld/video/upload/v1744462370/K%C4%B1rm%C4%B1z%C4%B1_ka%C3%A7an-9_qgnpyk.mp4",
            BackgroundImage="https://res.cloudinary.com/doadpcnld/image/upload/q_auto:eco/v1744482942/FI%CC%87NAL_EKRANLAR-SORU_EKRANI_Sangro_FC-100-min_vymwdx.jpg"
        }
       

    };
}


