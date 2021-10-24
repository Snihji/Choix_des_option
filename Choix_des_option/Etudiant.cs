using System;
using System.Collections.Generic;
using System.Text;
public class Etudiant
{   
	public int note;
    public string nom;
    public string a;
   
   public void choisir()
    {
        Console.WriteLine("Entrez votre note :");
        note = int.Parse(Console.ReadLine());
        Console.WriteLine("Enyrez le nom de l'option :");
        a=Console.ReadLine();   //case memoire de l'option 
    }
}

