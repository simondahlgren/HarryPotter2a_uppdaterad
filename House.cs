﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter_2a
{
    public abstract class House

    {
        public List<Wizard> Members { get; set; }

        public string Mascot { get; set; }
        public string HouseGhost { get; set; }

        public string Password { get; set; }

        public House()

        {



        }



        public virtual bool AmountOfLetters(string password)

        {


            if (password.Length >= 5)
            {

                return true;

            }
            else
            {
                return false;

            }


        }


        public virtual bool HasTheRightVowelsAndConsonants(string password)

        {
            bool isvowelorconsonant = false;

            string vowels = "aouåeiyäöAOUÅEIYÄÖ";
            string consonants = "bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ";
            char b = password[0];
            char e = password.Last();


            foreach (char c in vowels)
            {
                if (c == b)

                {
                    isvowelorconsonant = true;
                    break;

                }

                else
                {
                    isvowelorconsonant = false;
                }

            }

            if (isvowelorconsonant)

            {

                foreach (char c in consonants)
                {
                    if (c == e)

                    {
                        isvowelorconsonant = true;
                        break;

                    }

                    else

                        isvowelorconsonant = false;


                }


            }

            return isvowelorconsonant;

        }

        public bool SetPassword(string newpassword, string oldpassword)


        {

            bool passwordtest;

            if (passwordtest = AmountOfLetters(newpassword))
            {
                if (passwordtest = HasTheRightVowelsAndConsonants(newpassword))

                {
                    if (passwordtest = AmountOfLetters(oldpassword))

                        if (passwordtest = HasTheRightVowelsAndConsonants(oldpassword))
                        {

                            passwordtest = true;

                        }



                }


               


          }
            if (!passwordtest)
            {
                
                    passwordtest = false;
                    newpassword = null;

                }
            return passwordtest;
        }

          
        }  
    }



}
