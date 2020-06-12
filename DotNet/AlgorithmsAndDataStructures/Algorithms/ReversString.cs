using System.Linq;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class ReversString
    {
        public ReversString(){}

        public static string ReverseStringSolution1(string input){
            var inputchararray = input.ToList();
            for (int i = 0; i < inputchararray.Count / 2; i++)
            {
                var temp = inputchararray[i];
                inputchararray[i] = inputchararray[inputchararray.Count - i -1];
                inputchararray[inputchararray.Count - i -1] = temp;
            }
            return  string.Join("",inputchararray);
        }

        
        public static string ReverseStringSolution2(string input){
            var reversedstring = string.Empty;
            input.ToList().ForEach(character => {
                reversedstring = character + reversedstring;
            });
            return reversedstring.ToString();
        }
    }
}