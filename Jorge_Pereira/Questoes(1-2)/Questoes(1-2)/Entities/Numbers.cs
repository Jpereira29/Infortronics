using System.Text.Json;

namespace Questoes_1_2_.Entities
{
    internal class Numbers
    {
        private List<double> ListNumbers { get; set; } = new List<double>();

        public void VerifyChar()
        {
            var validator = true;
            while (validator)
            {
                var n = Console.ReadLine();

                if (n.ToUpper() == "X")
                {
                    validator = false;
                }
                else
                {
                    ListNumbers.Add(Convert.ToDouble(n));
                }
            }
        }

        public List<double> AscendingOrder()
        {
            var ascendingOrder = ListNumbers.OrderBy(x => x);
            foreach (var number in ascendingOrder)
            {
                Console.Write(number + ", ");
            }
            Console.WriteLine();
            ListNumbers = ascendingOrder.ToList();
            return ListNumbers;
        }

        public void CreateFileTxt(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            var fileToJson = JsonSerializer.Serialize(ListNumbers);

            StreamWriter file = File.CreateText(path);
            file.WriteLine("{");
            file.WriteLine(fileToJson);
            file.WriteLine("}");

            file.Close();
            Console.WriteLine("Lista salva!");
        }
    }
}