double CalculateAvg(int[] scores)
{
    int noOfAssignments = 0;
    int sum = scores.Sum();

    noOfAssignments = scores.Length - 1;

    double avg = (double)sum / (double)noOfAssignments;
    avg = Math.Round(avg, 1);
    return avg;
}

int CalculateAvg1(int[] scores)
{
    int noOfAssignments = 0;
    int sum = scores.Sum();

    noOfAssignments = scores.Length;

    int avg = sum / noOfAssignments;
    return avg;
}

int CalculateExtraCredit(int[] scores)
{
    int sum = scores.Sum();
    double tenPercent = sum * (10.0 / 100.0);

    return (int)tenPercent;
}


string DetermineGrade(double studentScore)
{
    string letterGrade = "";
    switch (studentScore)
    {
        case double n when (n >= 97 && n <= 100):
            letterGrade = "\tA+";
            break;
        case double n when (n >= 93 && n <= 96):
            letterGrade = "\tA";
            break;
        case double n when (n >= 90 && n <= 93):
            letterGrade = "\tA-";
            break;
        case double n when (n >= 87 && n <= 90):
            letterGrade = "\tB+";
            break;
        case double n when (n >= 83 && n <= 87):
            letterGrade = "\tB";
            break;
        case double n when (n >= 80 && n <= 83):
            letterGrade = "\tB-";
            break;
        case double n when (n >= 77 && n <= 80):
            letterGrade = "\tC+";
            break;
        case double n when (n >= 73 && n <= 77):
            letterGrade = "\tC";
            break;
        case double n when (n >= 70 && n <= 73):
            letterGrade = "\tC-";
            break;
        case double n when (n >= 67 && n <= 70):
            letterGrade = "\tD+";
            break;
        case double n when (n >= 63 && n <= 67):
            letterGrade = "\tD";
            break;
        case double n when (n >= 60 && n <= 63):
            letterGrade = "\tD-";
            break;
        case double n when (n >= 0 && n <= 60):
            letterGrade = "\tF";
            break;
        default:
            letterGrade = "Invalid";
            break;
    }

    return letterGrade;
}


string[] students = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
string[] headings = { "Student", "Exam Score", "Overall", "Grade", "Extra Credit" };

int[] sophiaExtraCredit = new int[] { 94, 90 };
int[] andrewExtraCredit = new int[] { 89 };
int[] emmaExtraCredit = new int[] { 89, 89, 89 };
int[] loganExtraCredit = new int[] { 96 };

int sophiaExtraCreditPercent = CalculateExtraCredit(sophiaExtraCredit);
int andrewExtraCreditPercent = CalculateExtraCredit(andrewExtraCredit);
int emmaExtraCreditPercent = CalculateExtraCredit(emmaExtraCredit);
int loganExtraCreditPercent = CalculateExtraCredit(loganExtraCredit);



int[] sophia = new int[] { 90, 86, 87, 98, 100, sophiaExtraCreditPercent };
int[] andrew = new int[] { 92, 89, 81, 96, 90, andrewExtraCreditPercent };
int[] emma = new int[] { 90, 85, 87, 98, 68, emmaExtraCreditPercent };
int[] logan = new int[] { 90, 95, 87, 88, 96, loganExtraCreditPercent };

double sophiaScore = CalculateAvg(sophia);
double andrewScore = CalculateAvg(andrew);
double emmaScore = CalculateAvg(emma);
double loganScore = CalculateAvg(logan);

double sophiaExamScore = 0;
double andrewExamScore = 0;
double emmaExamScore = 0;
double loganExamScore = 0;

int sophiaExtraCredit1 = (int)CalculateAvg1(sophiaExtraCredit);
int andrewExtraCredit2 = (int)CalculateAvg1(andrewExtraCredit);
int emmaExtraCredit3 = (int)CalculateAvg1(emmaExtraCredit);
int loganExtraCredit4 = (int)CalculateAvg1(loganExtraCredit);

double[] studentScores = new double[] { sophiaScore, andrewScore, emmaScore, loganScore };
double[] studentExamScores = new double[] { sophiaExamScore, andrewExamScore, emmaExamScore, loganExamScore };
int[] studentExtraCredits = { sophiaExtraCredit1, andrewExtraCredit2, emmaExtraCredit3, loganExtraCredit4 };


Console.WriteLine($"{headings[0],12} {headings[1],12} {headings[2],12} {headings[3],12} {headings[4],20}\n");
string message = "";
for (int i = 0; i < students.Length; i++)
{
    string grade = DetermineGrade(studentScores[i]);
    Console.WriteLine($"{students[i],12} {studentExamScores[i],8} {studentScores[i],12} {grade,10} {studentExtraCredits[i],20}");
}

Console.WriteLine(message);
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();


