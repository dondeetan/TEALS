using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class SockMerchant
    {
        public SockMerchant(){}
        public static int GetSockMerchant(int[] ar){            
            var results = 0;
            var sockcolorwithcount = new Dictionary<int,int>();
            for(int i = 0; i < ar.Length; i++ )
            {
                if (!sockcolorwithcount.ContainsKey(ar[i]))
                {
                    sockcolorwithcount.Add(ar[i],1);
                }
                else
                {
                    ++sockcolorwithcount[ar[i]];
                }
            }
            sockcolorwithcount.ToList().ForEach(color => {
                results += color.Value / 2;
            });
            return results;
        }
    }
}