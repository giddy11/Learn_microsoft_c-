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

float CalculateAvg(int[] scores, int noOfAssignments)
{
    int sum = scores.Sum();
    int noOf = score
    float avg = (float)sum / (float)noOfAssignments;

    return avg;
}

string DetermineGrade(float studentScore)
{
    string letterGrade = "";
    switch (studentScore)
    {
        case float n when (n >= 97 && n <= 100):
            letterGrade = "\tA+";
            break;
        case float n when (n >= 93 && n <= 96):
            letterGrade = "\tA";
            break;
        case float n when (n >= 90 && n <= 93):
            letterGrade = "\tA-";
            break;
        case float n when (n >= 87 && n <= 90):
            letterGrade = "\tB+";
            break;
        case float n when (n >= 83 && n <= 87):
            letterGrade = "\tB";
            break;
        case float n when (n >= 80 && n <= 83):
            letterGrade = "\tB-";
            break;
        case float n when (n >= 77 && n <= 80):
            letterGrade = "\tC+";
            break;
        case float n when (n >= 73 && n <= 77):
            letterGrade = "\tC";
            break;
        case float n when (n >= 70 && n <= 73):
            letterGrade = "\tC-";
            break;
        case float n when (n >= 67 && n <= 70):
            letterGrade = "\tD+";
            break;
        case float n when (n >= 63 && n <= 67):
            letterGrade = "\tD";
            break;
        case float n when (n >= 60 && n <= 63):
            letterGrade = "\tD-";
            break;
        case float n when (n >= 0 && n <= 60):
            letterGrade = "\tF";
            break;
        default:
            letterGrade = "Invalid";
            break;
    }

    return letterGrade;
}

// initialize variables - graded assignments 
int currentAssignments = 5;

string[] students = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophia = new int[] { 90, 86, 87, 98, 100 };
int[] andrew = new int[] { 92, 89, 81, 96, 90 };
int[] emma = new int[] { 90, 85, 87, 98, 68 };
int[] logan = new int[] { 90, 95, 87, 88, 96 };

float sophiaScore = CalculateAvg(sophia, currentAssignments);
float andrewScore = CalculateAvg(andrew, currentAssignments);
float emmaScore = CalculateAvg(emma, currentAssignments);
float loganScore = CalculateAvg(logan, currentAssignments);

float[] studentScores = new float[] { sophiaScore, andrewScore, emmaScore, loganScore };

Console.WriteLine("Student\t\tGrade\n");
string message = "";
for (int i = 0; i < students.Length; i++)
{
    string grade = DetermineGrade(studentScores[i]);
    Console.WriteLine($"{students[i]}:\t\t{studentScores[i]}{grade}");
}


//Console.WriteLine("Student\t\tGrade\n");
//Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
//Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB");
//Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
//Console.WriteLine("Logan:\t\t" + loganScore + "\tA");

Console.WriteLine(message);
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();


