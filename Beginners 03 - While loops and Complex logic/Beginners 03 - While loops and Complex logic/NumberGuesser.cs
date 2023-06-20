using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginners_03___While_loops_and_Complex_logic
{
    /// <summary>
    /// Pregunta al usuario un numero dentro de un rango y lo adivina en el minimo de intentos posibles
    /// </summary>
    public class NumberGuesser
    {
        #region Propiedades Publicas
        // private en el setter es para que solo e pueda modificar dentro de la misma clase, nunca dsd fuera

        //numero máximo que el usuario puede adivinar
        public int MaximumNumber { get; private set; }

        //llevar la cuenta del numero de intentos
        public int CurrentNumberOfGuesses { get; private set; } 

        //the start guess from
        public int CurrentGuessMinimum { get; private set; } 

        //the start guess to half of the max
        public int CurrentGuessMaximum { get; private set; }
        #endregion

        #region Constructor
        //ctor tab tab
        public NumberGuesser()
        {
            this.MaximumNumber = 100;        
        }
        #endregion

        #region Metodos Publicos
        public void InformUser()
        {
            Console.WriteLine($"Piensa un numero del 0 al {this.MaximumNumber}:");
            Console.ReadLine();
        }

        public void DiscoverNumber()
        {
            CurrentNumberOfGuesses = 0;
            CurrentGuessMinimum = 0;
            CurrentGuessMaximum = this.MaximumNumber / 2;

            while (this.CurrentGuessMinimum != this.CurrentGuessMaximum)
            {
                this.CurrentNumberOfGuesses++;

                //Pregunta si el numero está entre cierto rango
                Console.WriteLine($"Tu numero está entre {this.CurrentGuessMinimum} y {this.CurrentGuessMaximum}?");
                string response= Console.ReadLine();

                //Yes
                if (response?.ToLower().FirstOrDefault() == 'y')
                {
                    this.MaximumNumber = this.CurrentGuessMaximum;
                    this.CurrentGuessMaximum = this.CurrentGuessMaximum - (this.CurrentGuessMaximum - this.CurrentGuessMinimum) / 2;
                }

                //No
                else
                {
                    this.CurrentGuessMinimum= this.CurrentGuessMaximum+1;
                    int remainingDifference = this.MaximumNumber - this.CurrentGuessMaximum;

                    this.CurrentGuessMaximum += (int)Math.Ceiling(remainingDifference / 2f);
                }
                
                if(this.CurrentGuessMaximum+1==this.MaximumNumber)
                {
                    this.CurrentNumberOfGuesses++;

                    Console.WriteLine($"Es tu numero {this.CurrentGuessMinimum}?");
                    response= Console.ReadLine();

                    if (response?.ToLower().FirstOrDefault() == 'y') break;
                    else
                    {
                        this.CurrentGuessMinimum = this.MaximumNumber;
                        break;
                    }
                }
            }
        }
        public void AnnounceResults()
        {
            Console.WriteLine($"** Tu numero es {this.CurrentGuessMinimum} **");

            Console.WriteLine($"Adivinado en {CurrentNumberOfGuesses} intentos");

            Console.ReadLine();
        }
        #endregion
    }
}
