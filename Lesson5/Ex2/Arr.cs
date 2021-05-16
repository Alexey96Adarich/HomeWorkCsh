using System;
using System.Linq;
using System.Threading.Tasks;
using lesson5._2;

namespace lesson5._2
{
    class Arr
    {
        public static void menu()
        {
            MyString txt = new MyString("Britain is one of the most highly industrialised countries in the world:" +
                " for every person employed in agriculture 12 are employed in industry. The original base of British industry was coal-mining, iron and steel and textiles." +
                " Today the most productive sectors include high-tech industries, chemicals, finance and the service sectors, especially banking, insurance and tourism");
            Console.WriteLine("Текст");
            txt.Print();
            txt.SearchWords(5);
            txt.ClearLastSymbol('n');
            txt.SearchLongestWords();
            Console.ReadKey();
        }
    }
}