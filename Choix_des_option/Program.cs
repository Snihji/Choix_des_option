using System;
using System.Collections.Generic;
using System.Text;

namespace Choix_des_option
{
    class Program
    {
        
        static void Main(string[] args)
        {
           Option opt = new Option();
            Etudiant e1 = new Etudiant();
            e1.choisir();
           
            string[] Etd= new string[6];
            Etd[0] = "Ali Hajji";
            Etd[1] = "Salma Said";
            Etd[2] = "Kamal Benchekroune";
            Etd[3] = "Karim Aziz";
            Etd[4] = "Salwa Msiyah";
            Etd[5] = "Manal zghari";
            
            opt.note1 = 17;
            opt.note2 = 15;
            opt.note3 = 12;


            if (e1.note>opt.note2 && e1.a==opt.opt1 && opt.place<2)
            {
                Console.WriteLine("le nom de  candidat est : " + Etd[0] );
                Console.WriteLine("le nom de candidat est aussi : " + Etd[5]);
            }

            else if (e1.note > opt.note3 && e1.note <= opt.note2 && e1.a == opt.opt2 && opt.place < 2)
            {
                Console.WriteLine("le nom de candidat est : " + Etd[1]);
                Console.WriteLine("le nom de  candidat est aussi : " + Etd[3]);
            }

            else if (e1.note <= 12  && e1.a == opt.opt3 && opt.place < 2)
            {
                Console.WriteLine("le nom de candidat est : " + Etd[2]);
                Console.WriteLine("le nom de  candidat est aussi : " + Etd[4]);
            }

        }
    }
}
