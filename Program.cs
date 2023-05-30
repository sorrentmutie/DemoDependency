// See https://aka.ms/new-console-template for more information
using DemoDependency;

Console.WriteLine("Hello, World!");

// var b = new ClasseB(8);
IClasseB b = new ClasseB(8);
IClasseB c = new ClasseC();

var a = new ClasseA(c);

a.FaiQualcosaA();
