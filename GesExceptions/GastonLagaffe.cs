using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesExceptions
{
    internal class GastonLagaffe
    {
        public void trierCourruerEnRetard(int nbLettres)
        {
            Console.WriteLine("Quoi, " + nbLettres + " lettre(s) à trier ? ");
                try
                {
                    Console.WriteLine("OK, OK, je vais m'y mettre...");
                    if (nbLettres > 2 )
                    {
                        throw new Exception("Beacoup trop de lettres...");
                    }
                    Console.WriteLine("Ouf, j'ai fini.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("M'enfin ! " + ex.Message);
                    Console.WriteLine("Détails: " + ex.ToString());
                }
            Console.WriteLine("Après tout ce travail, une sieste s'ompose.");
        }

        public void rangerBureau()
        {
            try
            {
                Console.WriteLine("Ranger mon bureau ? Si tu insistes...");
                throw new Exception("Impossible, l'armoire est déjà pleine !");
            }
            catch (Exception ex)
            {
                Console.WriteLine("M'enfin ! " + ex.Message);
                Console.WriteLine("Détails: " + ex.ToString());
            }
        }

        public void faireSignerContrats()
        {
            try
            {
                Console.WriteLine("Encore ces contrats ? Ok, je les imprime...");
                imprimerContrats();
                Console.WriteLine("A présent une petite signature...");
                ajouterSignature();
                Console.WriteLine("Fantasio, les contrats sont signés !");
            }
            catch (Exception ex)
            {
                Console.WriteLine("M'enfin ! " + ex.Message);
            }
        }
        private void ajouterSignature()
        {
            Console.WriteLine("Signer ici, M'sieur Desmaeker.");
        }
        private void imprimerContrats()
        {
            Console.WriteLine("D'abord, mettre en route l'imprimante.");
            allumerImprimante();
            Console.WriteLine("Voilà, c'est fait !");
        }
        private void allumerImprimante()
        {
            Console.WriteLine("Voyons Comment allumer cette machine...");
            throw new Exception("Mais qui a démonté tout l'intérieur ?");
        }

    }
}