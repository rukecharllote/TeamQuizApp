using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamQuizApp
{
    public class QuestionLoader
    {
        private readonly List<Question> _questions = new List<Question>();
        private readonly Random _rand = new Random();

        public QuestionLoader(string path = "questions.csv")
        {
            string csvPath = Path.Combine(AppContext.BaseDirectory, path);
            foreach (var line in File.ReadAllLines(csvPath))
            {
                if (line.StartsWith("question")) continue;
                var cols = line.Split(',');
                _questions.Add(new Question
                {
                    Text = cols[0],
                    Choices = new[] { cols[1], cols[2], cols[3], cols[4] },
                    CorrectIndex = int.Parse(cols[5])
                });
            }
        }

        public Question GetRandomQuestion()
        {
            int idx = _rand.Next(_questions.Count);

            Question question = _questions[idx];

            _questions.RemoveAt(idx);

            return question;
        }
    }
}
