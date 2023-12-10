// This is how your code will be called.
// You can edit this code to try different testing cases.
using PallindromChallenge;
using System.Text;

string[] teststrings = { "Hello World!", "Race car!", "Rotor", "More cowbell!", "Madam, I'm Adam." };
int palcount = 0;
foreach (string str in teststrings)
{
    bool learnerResult = Answer.IsPalindrome(str);
    if (learnerResult)
        palcount++;
}
