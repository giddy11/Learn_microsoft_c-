namespace ClassLibrary1
{
    public class Class1
    {
    }

    public class Employee
    {
        public Employee()
        {
            empID = 101;
            empName = "No name";
            job = "some job title";
        }

        static Employee()
        {
            companyName = "ABC Industries";
        }

        public static void MainMethod()
        {
            var emp1 = new Employee();
            var emp2 = new Employee() { empID = 102, empName = "name2", job = "banking"};
            var emp3 = new Employee();

            

            Console.WriteLine();
        }

        public int empID;
        public string empName;
        public string job;

        public static string companyName;
    }


    public class Question
    {
        public Question()
        {
        }
        public Question(string questionText)
        {
            this.questionText = questionText;
            correctAnswerLetter = defaultCorrectAnswer;
        }
        public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter)
        {
            this.questionText = questionText;
            this.optionA = optionA;
            this.optionB = optionB;
            this.optionC = optionC;
            this.optionD = optionD;
            if (correctAnswerLetter == 'a' || correctAnswerLetter == 'b' || correctAnswerLetter == 'c' || correctAnswerLetter == 'd')
                this.correctAnswerLetter = correctAnswerLetter;
            else
                this.correctAnswerLetter = Question.defaultCorrectAnswer;
        }

        public bool AreOptionsValid()
        {
            int count = 0;

            if (this.optionA != null)
                count++;
            if (this.optionB != null)
                count++;
            if (this.optionC != null)
                count++;
            if (this.optionD != null)
                count++;

            if (count >= 2)
                return true;
            return false;
        }

        public static void Main()
        {
            var ques = new Question();
            var ques1 = new Question("Who is the president of Nigeria");
            var ques2 = new Question("Where is Gideon from?", "Edo", "Rivers", "Bayelsa", "Lagos", 'b');
            var ques3 = new Question() { questionText = "Where is Caroline from?", optionA = "Edo", optionB = "Rivers", optionC = "Bayelsa", optionD = "Lagos", correctAnswerLetter = 'c' };

            bool first = ques1.AreOptionsValid();
            bool second = ques2.AreOptionsValid();
            bool third = ques3.AreOptionsValid();

            Console.WriteLine();

        }



        public string questionText = null;
        public string optionA = null;
        public string optionB = null;
        public string optionC = null;
        public string optionD = null;
        public char correctAnswerLetter = defaultCorrectAnswer;
        private static char defaultCorrectAnswer = 'X';
    }
}
