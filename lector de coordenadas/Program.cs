using System.Text.RegularExpressions;

namespace lector
{
    class lectordecoordenadas
    {
        static void Main()
        {
            Console.WriteLine("Inserte las coordenadas con el formato \"(x,y)\", por favor");
            string coordenadas = Console.ReadLine();
            coordenadas = coordenadas.Remove(0, 1);
            coordenadas = coordenadas.Remove(3, 1);
            string[] coor = coordenadas.Split(',', StringSplitOptions.RemoveEmptyEntries);
            int[] coors = new int[2];
            for(int i = 0; i < coors.Length; i++)
            {
                coors[i] = int.Parse(coor[i]);
            }
            Console.WriteLine(coor[0] + "x " + coor[1] + "y");
        }
    }
}