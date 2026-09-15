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

        public Form1()
        {
            InitializeComponent();

            loader = new QuestionLoader();
            checker = new AnswerChecker();
            score = new ScoreManager();
            ui = new UiUpdater(questionLabel,
                new[] { answerButton1, answerButton2, answerButton3, answerButton4 },
                logListBox);

            LoadNextQuestion();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            var btn = sender as Button;
            int index = Array.IndexOf(new[] { answerButton1, answerButton2, answerButton3, answerButton4 }, btn);

            bool result = checker.CheckAnswer(current, index);
            score.Record(result);

            ui.LogResult(result ? "正解！" : "不正解...");
            ui.LogResult(score.GetResult());

            LoadNextQuestion();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            current = loader.GetRandomQuestion();
            ui.ShowQuestion(current);
        }
    }
}
