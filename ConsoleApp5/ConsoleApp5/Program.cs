using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programmer : Elyane Mehiyeva");
            Console.WriteLine("\n<------------1----------->");
            #region Task 1
            string FullName = "    Jhon Tomas   "; 
            FullName = FullName.Trim();
            string[] items = FullName.Split(' ');
            deleteNullItem(ref items);
            FullName = String.Join(" ", items);
            Console.WriteLine(FullName);
            #endregion
            Console.WriteLine("\n<------------2----------->");
            #region Task 2

            //Console.WriteLine("Metn Daxil Edin :");
            //string text = Console.ReadLine();
            //while (!checkCondition(text))
            //{
            //    Console.WriteLine("Metn Daxil Edin :");
            //    text = Console.ReadLine();
            //}
            //Console.WriteLine(text);

            string text = "Salam Dunya 3";
            Console.WriteLine(checkCondition(text));






            #endregion
            Console.WriteLine("\n<------------3----------->");
            #region Task 3
            string text_1 = "      Salam     Dunya Necesen      ";
            string text_2 = "      Salam Dunya      ";
            Console.WriteLine(checkWordsCondition(text_1));
            Console.WriteLine(checkWordsCondition(text_2));

            #endregion
            Console.WriteLine("\n<------------4----------->");
            #region Task 4
            int[] Array = { 1, 2, 3 };
            addNewItem(ref Array, 4);
            foreach (int item in Array)
            {
                Console.WriteLine(item);
            }
            //int[] Depo = { 1, 2, 3 };
            //addNewElement(ref Depo, 4);
            //foreach (int num in Depo)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion
            Console.WriteLine("\n<-----------END---------->");
        }
        #region Task 1 Metod
        static void deleteNullItem(ref string[] Array)
        {
            int count = 0;
            foreach (var item in Array)
            {
                if (item != "")
                {
                    count++;
                }
            }
            string[] newArray = new string[count];
            int index = 0;
            foreach (var item in Array)
            {
                if (item != "")
                {
                    newArray[index] = item;
                    index++;
                }
            }
            Array = newArray;
        }
        #endregion
        #region Task 2 Metod

        static bool checkCondition(string text)
        {
            bool conditionOne = false;
            bool conditionTwo = false;
            bool conditionThree = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    conditionOne = true;
                }
                if (Char.IsUpper(text[i]))
                {
                    conditionTwo = true;
                }
                if (Char.IsLower(text[i]))
                {
                    conditionThree = true;
                }


            }
            if (conditionOne && conditionTwo && conditionThree)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region Task 3 Metod
        static bool checkWordsCondition(string text)
        {
            text = text.Trim();
            string[] Words = text.Split(' ');
            deleteNullItem(ref Words);
            bool cond1 = false;
            bool cond2 = false;
            if(Words.Length == 2)
            {
                cond2 = true;
            }

            foreach (string word in Words)
            {
                if (Char.IsUpper(word[0]))
                {
                    cond1 = true;
                } else
                {
                    cond1 = false;
                }
            }
            if(cond1 && cond2)
            {
                return true;
            } else
            {
                return false;
            }

        }
       
        #endregion
        #region Task 4 Metod
        static void addNewItem(ref int[] intArray,int element)
        {
            Array.Resize(ref intArray, intArray.Length + 1);
            intArray[intArray.Length - 1] = element;
        }
        //static void addNewElement(ref int[] Depo, int element)
        //{
        //    int lenghtOfArray = Depo.Length;
        //    int newArrayLenght = lenghtOfArray + 1;
        //    Array.Resize(ref Depo, newArrayLenght);
        //    Depo[lenghtOfArray] = element;
        //}
        #endregion

        
    }
}
