using System.Runtime.InteropServices.ComTypes;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class ArithmeticExpresionsController: ControllerBase
    {
        private const int MAX_LENGTH = 10;
        [HttpGet("{n}")]  
        public ActionResult<string> GetUser(int n){
            if(!ValidateConstraint(n))return Ok("Invalid Number");
            return Ok(GetResultOperation(n));
        }

        private bool ValidateConstraint(int n){
            int pow = (int)Math.Pow(10, 4);
            if(n>2 && n<=pow) return true;
            return false;

        }
        private List<int> GenerateList(int n){
           List<int> numeros = new List<int>();
           int tmp = 0;
           Random rnd = new Random();

           for (int i = 0; i < n && i <= MAX_LENGTH; i++) 
           {        
                tmp = rnd.Next(1, 101);
                if(numeros.Contains(tmp)){
                    i--;
                }
                else{  
                    numeros.Add(tmp);
                }
           }
           return numeros;
        }
        private static bool FindDivisibleCombination(List<int> numbers, out string operation) {

            List<string> operators = new List<string> { "+", "-", "*" };
            List<List<string>> allCombinations = GenerateAllCombinations(operators, numbers.Count - 1);

            foreach (List<string> combination in allCombinations) {
              //  List<int> tempNumbers = new List<int>(numbers);
                int tempResult = numbers[0];
                var sb = new StringBuilder(tempResult.ToString());
                
                for (int i = 0; i < combination.Count; i++) {
                    int nextNumber = numbers[i + 1];
                    sb.Append(combination[i]).Append(nextNumber);
                    switch (combination[i]) {
                        case "+":
                            tempResult += nextNumber;
                            break;
                        case "-":
                            tempResult -= nextNumber;
                            break;
                        case "*":
                            tempResult *= nextNumber;
                            break;
                    }
                }
                if (tempResult % 101 == 0 && tempResult > 101) {
                    operation = sb.ToString();
                    return true;
                }
            }
            operation = null;
            return false;
        }


         private static List<List<string>> GenerateAllCombinations(List<string> operators, int length) {
            List<List<string>> allCombinations = new List<List<string>>();
            GenerateAllCombinationsRecursive(allCombinations, new List<string>(), operators, length);
            return allCombinations;
        }

        private static void GenerateAllCombinationsRecursive(List<List<string>> allCombinations, List<string> combination, List<string> operators, int length) {
            if (combination.Count == length) {
                allCombinations.Add(combination);
            } else {
                foreach (string op in operators) {
                    List<string> newCombination = new List<string>(combination);
                    newCombination.Add(op);
                    GenerateAllCombinationsRecursive(allCombinations, newCombination, operators, length);
                }
            }
        }
        
        private string GetResultOperation(int n){
            var numbers = GenerateList(n);
            string result = "";
            while (!FindDivisibleCombination(numbers, out result))
            {
                numbers = GenerateList(n);
            }
            Console.WriteLine($"La operación {result} da un resultado válido");
            return result;        
        }
        
    }
}