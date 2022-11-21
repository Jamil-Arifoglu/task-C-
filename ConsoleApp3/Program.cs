#region Student
//using ConsoleApp3;


//Student_class Student = new Student_class("Cemil", "Isayev", "P230", 95, false);


#endregion
Console.WriteLine("cumle qeyd edin");
string cumle=Console.ReadLine();
string cumle2 = cumle.ToUpper();
Console.WriteLine("cavab:");
Ceka(cumle2);

static void Ceka(string cumle)
{
	for (int i = 0; i < cumle.Length; i++)
	{
		if (i == 0)
		{
			Console.Write(cumle[i]);
			cumle = cumle.ToLower();
			i++;
		}
		else if (cumle[i] ==' ')
		{    cumle=cumle.ToUpper();	
			Console.Write(cumle[i]);
			i++;
		  continue;
		}
		
		Console.Write(cumle[i]);
        cumle = cumle.ToLower();
    }

}
