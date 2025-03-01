namespace OPPallatkert
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Allatkert allatkert = new Allatkert();
			allatkert.Beolvasas();
			allatkert.Verseny();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Az állatkert telítettsége:");
            Console.WriteLine("megtelt: piros \nmaradék hely: zöld");
           
            allatkert.Szamok();
        }
	}
}
