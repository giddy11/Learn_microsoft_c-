/*You've already completed an initial version of the application. The Starter code project for this Guided project module includes a Program.cs file that provides the following code features:

The code declares variables used to define student names and individual exam scores for each student.
The code includes the variables and algorithms used to sum the exam scores and calculate the average exam score for each student.
The code includes a hard coded letter grade that the developer must apply manually.
The code includes Console.WriteLine() statements to display the student grading report.

Student         Grade

Sophia:         92.2    A-
Andrew:         89.6    B+
Emma:           85.6    B
Logan:          91.2    A-

97 - 100   A+
93 - 96    A
90 - 92    A-
87 - 89    B+
83 - 86    B
80 - 82    B-
77 - 79    C+
73 - 76    C
70 - 72    C-
67 - 69    D+
63 - 66    D
60 - 62    D-
0  - 59    F

 */

double CalculateAvg(int[] scores)
{
    int sum = scores.Sum();
    int noOfAssignments = scores.Length - 1;
    double avg = (double)sum / (double)noOfAssignments;
    avg = Math.Round(avg, 1);
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

string[] students = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] sophiaExtraCredit = new int[] { 94, 90 };
int[] andrewExtraCredit = new int[] { 89 };
int[] emmaExtraCredit = new int[] { 89, 89, 89 };
int[] loganExtraCredit = new int[] { 96 };
int[] beckyExtraCredit = new int[] { 92, 92 };
int[] chrisExtraCredit = new int[] { 94, 96, 98 };
int[] ericExtraCredit = new int[] { 100, 80, 90 };
int[] gregorExtraCredit = new int[] { 91, 91 };

int sophiaExtraCreditPercent = CalculateExtraCredit(sophiaExtraCredit);
int andrewExtraCreditPercent = CalculateExtraCredit(andrewExtraCredit);
int emmaExtraCreditPercent = CalculateExtraCredit(emmaExtraCredit);
int loganExtraCreditPercent = CalculateExtraCredit(loganExtraCredit);
int beckyExtraCreditPercent = CalculateExtraCredit(beckyExtraCredit);
int chrisExtraCreditPercent = CalculateExtraCredit(chrisExtraCredit);
int ericExtraCreditPercent = CalculateExtraCredit(ericExtraCredit);
int gregorExtraCreditPercent = CalculateExtraCredit(gregorExtraCredit);



int[] sophia = new int[] { 90, 86, 87, 98, 100, sophiaExtraCreditPercent };
int[] andrew = new int[] { 92, 89, 81, 96, 90, andrewExtraCreditPercent };
int[] emma = new int[] { 90, 85, 87, 98, 68, emmaExtraCreditPercent };
int[] logan = new int[] { 90, 95, 87, 88, 96, loganExtraCreditPercent };
int[] becky = new int[] { 92, 91, 90, 91, 92, beckyExtraCreditPercent };
int[] chris = new int[] { 84, 86, 88, 90, 92, chrisExtraCreditPercent };
int[] eric = new int[] { 80, 90, 100, 80, 90, ericExtraCreditPercent };
int[] gregor = new int[] { 91, 91, 91, 91, 91, gregorExtraCreditPercent };

double sophiaScore = CalculateAvg(sophia);
double andrewScore = CalculateAvg(andrew);
double emmaScore = CalculateAvg(emma);
double loganScore = CalculateAvg(logan);
double beckyScore = CalculateAvg(becky);
double chrisScore = CalculateAvg(chris);
double ericScore = CalculateAvg(eric);
double gregorScore = CalculateAvg(gregor);

double[] studentScores = new double[] { sophiaScore, andrewScore, emmaScore, loganScore, beckyScore, chrisScore, ericScore, gregorScore };

Console.WriteLine("Student\t\tGrade\n");
string message = "";
for (int i = 0; i < students.Length; i++)
{
    string grade = DetermineGrade(studentScores[i]);
    Console.WriteLine($"{students[i]}:\t\t{studentScores[i]}{grade}");
}

Console.WriteLine(message);
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();


