using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge.CodeChallenge.Hash
{
   public class HashTable
    {

        // List<string , int> 
       // KeyValuePair<string, int>[] dataList = new KeyValuePair<string, int>[200];
       public string[] arrayKey = new string[200];
       public int?[] arrayvalue= new int?[200];
        public void set(string key , int value) {

          int hashedKey = hash(key);

            // add the value and solve the collisions by replace the value
            arrayvalue[hashedKey] = value;
            arrayKey[hashedKey] = key;
            Console.WriteLine($"the data value {value} has set in place { hashedKey}");
            
        }

        public int hash(string key)
        {
            int lestLenght = arrayvalue.Length;
            int num = 0;
            //string[] keyData= key.Split("");
            byte[] keyData = Encoding.ASCII.GetBytes(key);
            
            foreach (char item in keyData)
            {
                num += item;
            }
            return (num % lestLenght);
        }

        public int? get(string key)
        {
            int hashedKey = hash(key);

            if (contains(key))
            {
                return arrayvalue[hashedKey];
                // return $" the value = {arrayvalue[hashedKey]}";
            }
            else
                return null;
             //   return $" the value is null= {arrayvalue[hashedKey]}";

        }

        public bool contains(string key)
        {
            int hashedKey = hash(key);
            if (arrayvalue[hashedKey] != null)
            {
                return true;
            }
            return false;
        }

        public List<string> keys()
        {
            

            List <string> listKeys = new List<string>();
            for (int i=0; i<arrayKey.Length;i++)
            {
                if (arrayKey[i] != null)
                {
                    listKeys.Add(arrayKey[i]);

                }
            }

            return listKeys;
        }

    }
}
