using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace D03
{
    internal class Player
    {
        int age;
        int score;
        string name;
        static int count = 0;
        static Player()
        {
            count = 100;
            
        }
        public Player()
        {
            age = default;
            score = default;
            name = default;
            count++;
        }
        public Player(string _name)
        {
            name = _name;
            count++;
        }
        public Player(int _age,int _score , string _name)
        {
           this.age= _age;
           this.name = _name;
           this.score = _score;
           count++;
        }
        public  static int getCounter() 
        {
            
                     return count; 
        }
        public static int Count {             
            get { return count; } }
        public override string ToString()
        {
            return $"{name}has Score => {score}";
        }

        public static void getName(Player player)
        {
            Console.WriteLine(player.name);
            player.score = 10;
           // Console.WriteLine(name);Error
        }
    }
}
