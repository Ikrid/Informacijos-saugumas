using System;
using System.Collections.Generic;

public class TravelingSalesmanProblem
{
    public static void Main(string[] args)
    {
        // Матрица расстояний
        int[,] distances = new int[5, 5]
        {
            { 0, 5, 9, 7, 3 },
            { 5, 0, 2, 8, 4 },
            { 9, 2, 0, 3, 6 },
            { 7, 8, 3, 0, 1 },
            { 3, 4, 6, 1, 0 }
        };

        // Названия городов
        string[] cities = { "A", "B", "C", "D", "E" };

        // Алгоритм жадного коммивояжера
        List<int> tour = new List<int>();

        // Добавляем A в начало
        tour.Add(0);

        int totalDistance = 0;

        while (tour.Count < 5)
        {
            int bestNeighbor = -1;
            int bestDistance = int.MaxValue;

            for (int j = 0; j < 5; j++)
            {
                if (!tour.Contains(j))
                {
                    int distance = distances[tour[tour.Count - 1], j];

                    if (distance < bestDistance)
                    {
                        bestNeighbor = j;
                        bestDistance = distance;
                    }
                }
            }

            tour.Add(bestNeighbor);
            totalDistance += bestDistance;
        }

        // Добавляем A в конец
        tour.Add(0);

        // Вывод результата
        Console.WriteLine("Viso maršruto ilgis: " + totalDistance);
        Console.WriteLine("Maršrutas:");
        foreach (int city in tour)
        {
            Console.Write(cities[city] + " ");
        }
        Console.WriteLine();

        // Išspausdiname sferinės funkcijos reikšmę
        int sferineFunkcija = SferineFunkcija(tour, distances);
        Console.WriteLine("Sferinės funkcijos reikšmė: " + sferineFunkcija);
    }

    // Sferinės funkcijos skaičiavimas
    public static int SferineFunkcija(List<int> maršrutas, int[,] atstumai)
    {
        int sumaKvadratu = 0;
        for (int i = 0; i < maršrutas.Count - 1; i++)
        {
            int miesto1 = maršrutas[i];
            int miesto2 = maršrutas[i + 1];
            sumaKvadratu += atstumai[miesto1, miesto2] * atstumai[miesto1, miesto2];
        }
        return sumaKvadratu;
    }
}