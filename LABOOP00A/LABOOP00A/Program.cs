// See https://aka.ms/new-console-template for more information
using LABOOP00A;
using System.Runtime.InteropServices;

Students student1 = new Students();
student1.name = "A";
student1.weight = 50f;

Students student2 = new Students();
student2.name = "B";
student2.weight = 50f;

Students student3 = new Students();
student3.name = "C";
student3.weight = 60f;

Students student4 = new Students();
student4.name = "D";
student4.weight = 60f;

Students student5 = new Students();
student5.name = "E";
student5.weight = 40f;

float avgWeight = (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight)/5;
Console.WriteLine("Weight avg of Student : " + avgWeight);