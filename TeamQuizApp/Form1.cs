using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamQuizApp
{
    public partial class Form1 : Form
    {
        private readonly QuestionLoader loader;
        private readonly AnswerChecker checker;
        private readonly ScoreManager score;
        private readonly UiUpdater ui;

        private Question current;

        // 追加
        private int questionCount = 0;
        private const int MaxQuestions = 5;
        public Form1()
        {
            InitializeComponent();

            loader = new QuestionLoader();
            checker = new AnswerChecker();
            score = new ScoreManager();
            ui = new UiUpdater(questionLabel,
                new[] { answerButton1, answerButton2, answerButton3, answerButton4 },
                logListBox);

            retryButton.Visible = false;


            LoadNextQuestion();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            int index = Array.IndexOf(
                new[] { answerButton1, answerButton2, answerButton3, answerButton4 },
                btn);

            bool result = checker.CheckAnswer(current, index);

            score.Record(result);
            
            
            //問題の累積を追加。
            questionCount++;

            ui.LogResult(result ? "正解！" : "不正解...");
            ui.LogResult(score.GetResult());

            //5問やったら終わる処理
            if (questionCount >= MaxQuestions)
            {
                EndQuiz();
                return;
            }



            LoadNextQuestion();
        }

        private void LoadNextQuestion()
        {
            current = loader.GetRandomQuestion();
            ui.ShowQuestion(current);
        }

        private void EndQuiz()
        {
            questionLabel.Text = "クイズ終了！";

            answerButton1.Enabled = false;
            answerButton2.Enabled = false;
            answerButton3.Enabled = false;
            answerButton4.Enabled = false;

            retryButton.Visible = true;

            ui.LogResult("最終結果：" + score.GetResult());
        }
        private void retryButton_Click(object sender, EventArgs e)
        {
            questionCount = 0;

            answerButton1.Enabled = true;
            answerButton2.Enabled = true;
            answerButton3.Enabled = true;
            answerButton4.Enabled = true;

            retryButton.Visible = false;

            LoadNextQuestion();
        }

    }

    }

