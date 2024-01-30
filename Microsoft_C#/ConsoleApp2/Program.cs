// See https://aka.ms/new-console-template for more information
using ClassLibrary2;

Console.WriteLine("Hello, World!");


var warr = new Warrior("Arthur", 100, 20, 10);
var mage = new Mage("Merlin", 80, 15, 5);
var dragon = new Dragon("Smaug", 200, 30, 20);

var game = new Game();
game.Battle(warr, mage);