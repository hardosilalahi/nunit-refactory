using System.Net.Mime;
using System;
using System.Collections.Generic;
using System.Linq;

namespace refactoryAssignment
{
    public class Class1
    {
        public int prompt(string text){
            return text.Length;
        }

        public char grading(int grade){
            if(grade >= 90){
                return 'A';
            }
            else if(grade >= 80 && grade < 90){
                return 'B';
            }
            else if(grade >= 70 && grade < 80){
                return 'C';
            }
            else if(grade >= 60 && grade < 70){
                return 'D';
            }
            else{
                return 'E';
            }
        }

        public string OddEven(int val){
            if(val % 2 == 0){
                return "Genap";
            }
            else{
                return "Ganjil";
            }
        }

        public string IsLeapYear(int year){
            if(year % 4 == 0 && year % 100 == 0 && year % 400 == 0){
                return "Kabisat";
            }
            else if(year % 4 == 0 && year % 100 == 0 && year % 400 != 0){
                return "Bukan Kabisat";
            }
            else if(year % 4 == 0 && year % 100 != 0){
                return "Kabisat";
            }
            else if(year % 4 != 0){
                return "Bukan Kabisat";
            }
            else{
                return "Error input, try again";
            }
        }

        public string FilmRating(int age){
            if(age >= 21){
                return "DEWASA";
            }
            else if(age >= 13 && age < 21){
                return "REMAJA";
            }
            if(age >= 9 && age < 13){
                return "BIMBINGAN ORANGTUA";
            }
            else{
                return "SEMUA UMUR";
            }
        }

        public List<int> LoopInRange(int val1, int val2){
            List<int> ListNumber = new List<int>();

            for(int i = val1; i <= val2; i++){
                ListNumber.Add(i);
            }
            return ListNumber;
        }

        public List<int> EvenNumbers(){
            List<int> listNumber = new List<int>();
            
            for(int i = 0; i <= 100; i++){
                if(i % 2 != 0){
                    listNumber.Add(i);
                }
            }
            return listNumber;
        }

        public List<string> GanjilGenapKelipatan(){
            List<string> listResults = new List<string>();

            for(int i = 0; i <= 1000; i++){
                if(i % 2 != 0 && i % 5 == 0){
                    listResults.Add($"{i}. Ganjil Kelipatan Lima");
                }
                else if(i % 2 == 0 && i % 5 == 0){
                    listResults.Add($"{i}. Genap Kelipatan Lima");
                }
                else if(i % 2 == 0){
                    listResults.Add($"{i}. Genap");
                }
                else if(i % 2 != 0){
                    listResults.Add($"{i}. Ganjil");
                }

            }
            return listResults;
        }

        public string ReverseString(string text){
            string[] textList = text.Split(' ');

            Array.Reverse(textList);

            string text2 = String.Join(" ", textList);
            return text2;
        }

        public string[] AddToArray(string[] array1, string val1, string val2){
            string[] array2 = new string[array1.Length + 2];

            for(int i = 0; i < array2.Length-1; i++){
                if(i == 0){
                    array2[i] = val1;
                }
                else if(i == array2.Length - 1){
                    array2[i] = val2;
                }
                else{
                    array2[i] = array1[i - 1];
                }
            }
            return array2;
        }
    }
}
