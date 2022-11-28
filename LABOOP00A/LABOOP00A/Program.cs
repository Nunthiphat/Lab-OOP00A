// See https://aka.ms/new-console-template for more information
using LABOOP00A;

Students student1 = new Students();
student1.name = "Nate";
student1.weight = 60f;

Students student2 = new Students();
student2.name = "Pu";
student2.weight = 69f;

Students student3 = new Students();
student3.name = "Toi";
student3.weight = 63f;

Students student4 = new Students();
student4.name = "Not";
student4.weight = 63f;

Students student5 = new Students();
student5.name = "Peaw";
student5.weight = 39f;

float avgWeight = (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight) / 5;
Console.WriteLine("Weight avg of Student : " + avgWeight);