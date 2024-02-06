using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libMotdepasse;

namespace cslMotdepasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string login, mdp, mdp2;

            Console.WriteLine("Saisissez votre login");
            login = Console.ReadLine();
            Console.WriteLine("Saisissez votre mot de passe");
            mdp = Console.ReadLine();
            Console.WriteLine("Confirmez votre mot de passe");
            mdp2 = Console.ReadLine();
            MotdePasse Mdp = new MotdePasse(login, mdp);

            if (Mdp.Vérifier(mdp2))
            {
                if (Mdp.Longueur() && (Mdp.estNumeric()) && (Mdp.estMajuscule()) & (Mdp.estSpecial()))
                {

                    Console.WriteLine("Mot de passe valide");

                }
                    
                 //   Console.WriteLine(Mdp.Longueur());

            }
            else
            {
                Console.WriteLine("Les mots de passe ne sont pas identiques, ressaisiez votre mot de passe");
            }
           // Console.WriteLine(Mdp.Longueur());
        }
    }
}
