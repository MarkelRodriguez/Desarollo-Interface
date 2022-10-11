// See https://aka.ms/new-console-template for more information


using Console_Herentzia;

try
{
    A objA = new A();
    objA.prop1 = "pepe";
    objA.prop2 = "20";
    objA.Erakutsi();
    B objB = new B();
    objB.prop1 = "izaskun";
    objB.prop2 = "47345353534";
    objB.prop3 = "Kortabitarte";
    objB.Erakutsi();
    Console.ReadLine();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.ReadLine();
}
