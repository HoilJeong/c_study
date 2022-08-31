using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Name: _36_Hashtable
 * DESC: Hashtable 기본
 */

namespace _36_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add("pos", 10);
            hashTable.Add("name", "Jack");
            hashTable["weight"] = 10.8f;

            foreach (object key in hashTable.Keys)
            {
                Console.WriteLine("key: " + key + " data: " + hashTable[key]);
            }

            Console.WriteLine("");

            Hashtable hashtableCopy = new Hashtable()
            {
                ["pos"] = 10,
                ["name"] = "Jack",
                ["weight"] = 10.8f,
            };

            foreach (object key in hashTable.Keys)
            {
                Console.WriteLine("key: " + key + " data: " + hashTable[key]);
            }              
        }
    }
}
