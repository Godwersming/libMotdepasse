using System;

namespace libMotdepasse
{
    public class MotdePasse
    {
        private string login;
        private string mdp;

        public MotdePasse(string login, string mdp)
        {
            this.login = login;
            this.mdp = mdp;
        }

        public bool Vérifier(string mdp2)
        {
            return mdp == mdp2;
        }


        public bool Longueur()
        {
            return mdp.Length >= 12; 
        }


        /* estNumeric Utilise la fonction char is number*/

        public bool estNumeric()
        {
            foreach (char c in mdp)
            {
                if (char.IsNumber(c))
                {
                    return true;
                }
            }
            return false;
        }

        /* estMajuscule Utilise la fonction char is upper*/


        public bool estMajuscule()
        {
            foreach (char c in mdp)
            {
                if (char.IsUpper(c))
                {
                    return true;
                }
            }
            return false;
        }
    


    /* EstSpecial Utilise la fonction char is letter or digit*/

    public bool estSpecial()
        {
            foreach (char c in mdp)
            {
                if (char.IsLetterOrDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }

}

