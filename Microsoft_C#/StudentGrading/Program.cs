
using ClassLibrary2;

var Per = new Person() { Name = "Gideon", Email = "gid" };

bool ans = Per.Equals(new Person() { Name = "Gideon", Email = "gid" });

Console.WriteLine(ans);