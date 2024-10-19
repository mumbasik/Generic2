namespace ConsoleApp16
{
    class Dict
    {
        Dictionary<string, string> words = new Dictionary<string, string>()
        {
            {"Желтый",  "Yellow"}, {"Синий", "Blue"}, {"Красный", "Red"}
        };


        public void addTranslate(string word, string translate)
        {
            if (!words.ContainsKey(word))
            {
                words.Add(word, translate);
            }


            foreach (KeyValuePair<string, string> pair in words)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }


        public void removeWord(string word)
        {
            if (words.ContainsKey(word))
            {
                words.Remove(word);
            }


            foreach (KeyValuePair<string, string> pair in words)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }


        public void removeTranslate(string word)
        {
            if (words.Remove(word))
            {
                Console.WriteLine($"Removed {word}.");
            }


            foreach (KeyValuePair<string, string> pair in words)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }


        public void changeTranslate(string key, string newTranslate)
        {
            if (words.ContainsKey(key))
            {
                words[key] = newTranslate;
            }


            foreach (KeyValuePair<string, string> pair in words)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }


        public void searchTranslate(string key)
        {
            if (words.TryGetValue(key, out string value))
            {
                Console.WriteLine($"{key}: {value}");
            }

        }
    }

    class Oceanarium
    {
        public string name { get; set; }
        public string color { get; set; }
        public double weight { get; set; }
        public int age { get; set; }
        public Oceanarium(string name, string color, double weight, int age)
        {
            this.name = name;
            this.color = color;
            this.weight = weight;
            this.age = age;
        }
        public void Print()
        {

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Age: " + age);

        }

    }
    class Sea : Oceanarium
    {
        public List<Oceanarium> ocean = new List<Oceanarium>();


        public Sea(string name, string color, double weight, int age) : base(name, color, weight, age) { }


        public void AddCreature(Oceanarium creature)
        {
            ocean.Add(creature);
        }


        public void PrintAllCreatures()
        {
            foreach (var creature in ocean)
            {
                creature.Print();
            }
        }
    }



    internal class Program
    {




        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public static T MaxSum<T>(T a, T b, T c) where T : struct, IComparable<T>
        {
            T max1 = Max(a, b);
            return Max(max1, c);
        }
        static void Main(string[] args)
        {
            //N1

            Dict obj = new Dict();
            obj.addTranslate("Фиолетовый", "Purple");
            obj.removeTranslate("Красный");
            obj.changeTranslate("Синий", "White");
            obj.searchTranslate("Желтый");
            //N2
            int num1 = 10;
            int num2 = 20;
            int num3 = 15;
            int maxInt = MaxSum(num1, num2, num3);
            Console.WriteLine($"Максимальное из трех целых чисел: {maxInt}");
            //N3
            Sea sea = new Sea("Atlantic", "Blue", 0, 0);


            sea.AddCreature(new Oceanarium("Fish", "Red", 10.0, 5));
            sea.AddCreature(new Oceanarium("Shark", "Gray", 200.0, 15));
            sea.AddCreature(new Oceanarium("Whale", "Blue", 3000.0, 25));


            sea.PrintAllCreatures();
        }
    }
}
