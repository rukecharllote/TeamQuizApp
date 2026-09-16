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

        // 問題数追加
        private int questionCount = 0;
        private const int MaxQuestions = 5;

        public Form1()
        {
            InitializeComponent();

            loader = new QuestionLoader();
            checker = new AnswerChecker();
            score = new ScoreManager();

            ui = new UiUpdater(
                questionLabel,
                new[]
                {
                    answerButton1,
                    answerButton2,
                    answerButton3,
                    answerButton4
                },
                logListBox
            );

            // 最初はリトライボタンを隠す
            retryButton.Visible = false;

            // 最初の問題を表示
            LoadNextQuestion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            int index = Array.IndexOf(
                new[]
                { answerButton1,answerButton2,answerButton3,answerButton4},
                btn);

            // 正解判定
            bool result = checker.CheckAnswer(current, index);

            // スコア記録
            score.Record(result);

            // 問題数を1増やす
            questionCount++;

            // 結果表示
            ui.LogResult(result ? "正解！" : "不正解...");
            ui.LogResult(score.GetResult());

            // 5問回答したら終了
            if (questionCount >= MaxQuestions)
            {
                EndQuiz();
                return;
            }

            // 次の問題へ
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

            // 回答ボタンを押せなくする
            answerButton1.Enabled = false;
            answerButton2.Enabled = false;
            answerButton3.Enabled = false;
            answerButton4.Enabled = false;

            // リトライボタンを表示
            retryButton.Visible = true;

            // 最終結果
            ui.LogResult("最終結果：" + score.GetResult());
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            // 問題数をリセット
            questionCount = 0;

            // スコアをリセット
            score.Reset();

            // 前回のログを全部消す
            logListBox.Items.Clear();

            // 回答ボタンを再び有効にする
            answerButton1.Enabled = true;
            answerButton2.Enabled = true;
            answerButton3.Enabled = true;
            answerButton4.Enabled = true;

            // リトライボタンを隠す
            retryButton.Visible = false;

            // 新しい問題を表示
            LoadNextQuestion();
        }
    }
}