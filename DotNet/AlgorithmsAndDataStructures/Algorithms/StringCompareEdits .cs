namespace AlgorithmsAndDataStructures.Algorithms
{    
    public class StringCompareEdits 
    {
        /// <summary>
        /// Given two strings, return true if they are one edit away from each other,else return false.
        /// An edit is insert/replace/delete a character. 
        /// Ex. {"abc","ab"}->true, {"abc","adc"}->true, {"abc","cab"}->false
        /// </summary>
        public StringCompareEdits (){}

        /// <summary>
        /// The length difference between two input strings should not be more than 1.
        /// When the length of the strings is same, the number of different chars should not be more than 1. 
        /// If the length difference is 1, then either one char can be inserted in the short string or deleted from the longer string. Considering that, the number of different char should not be more than 1.
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        /// <returns></returns>
        public static bool IsEdit(string string1, string string2){
            
            var string1chars = string1.ToCharArray();
            var string2chars = string2.ToCharArray();
            var string1length = string1.Length;
            var string2length = string2.Length;
            int countofdifference = 0;
            int string1count  = 0, string2count = 0;  
            
            //First Case
            // The length difference between two input strings should not be more than 1.
            if ((string1length - string2length) > 1 || (string2length - string1length) > 1)
                return false;

            //Increment the proper string counts before the while loop so we just increment 

            while(string1count < string1length && string2count < string2length)         
            {
                //Check the differences of characters between strings
                if (string1chars[string1count] != string2chars[string2count])
                {                    
                    countofdifference++;
                    if (string1length > string2length)
                        string1count++;
                    else if (string1length < string2length)
                        string2count++;
                    else
                        {
                            string1count++;
                            string2count++;
                        }
                }
                else{
                    string1count++;
                    string2count++;                    
                }    
                //If the difference of greater than 1 then resturn false
                if (countofdifference > 1) {
                    return false;
                }                
            }
             // If the length of the string is not same. ex. "abc" and "abde" are not one edit distance.
            if (countofdifference == 1 && string1count != string2count && (string1count != string1length || string2count != string2length)) 
                return false;

            return true;
        }       
    }
}