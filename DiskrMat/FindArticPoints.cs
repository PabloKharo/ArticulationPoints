using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskrMat
{
    class FindArticPoints
    {
        public List<int> Points { get; set; }                                   // Список нужных нам вершин
        private List<List<int>> edges = new List<List<int>>();                  // Список смежностей
        private List<bool> visited = new List<bool>();                          // Список посещенных вершин
        private List<int> pos = new List<int>();                                // Список номеров обоходов для вершин
        private List<int> lowest = new List<int>();                             // Список смежности с минимальной по порядку обхода вершиной
        private int timer;                                                      // Номер точки по порядку обхода

        private void Dfs(int current, int parent = -1)
        {
            visited[current] = true;                                            // Добавление вершины в список посещенных
            pos[current] = lowest[current] = timer++;                           // Определение номера вершины и значения минимума (ее самого)
            int children = 0;                                                   // Переменная для подсчета детей для случая, когда первая вершина - нужная 
            for (int i = 0; i < edges[current].Count(); i++)                    // Перебор всех смежных вершины
            {
                int next = edges[current][i];                                   // Следующая вершина
                if (next == parent)                                             // Если следующая вершина родительская, то ничего не делать
                    continue;
                if (visited[next])                                              // Если вершина посещена
                    lowest[current] = Math.Min(lowest[current], pos[next]);     // Если номер смежной вершины меньше, чем минимум текущей
                else                                                            // В другом случае
                {
                    Dfs(next, current);                                         // Рекурсивно выполнить функцию для следующей вершины
                    lowest[current] = Math.Min(lowest[current], lowest[next]);  // Значение минимума текущей вершины - минимум от следующей и текущей вершины
                    if (lowest[next] >= pos[current] && parent != -1)           // Если минимум у следующей вершины больше позиции текущей, и это не корень, то
                        Points.Add(current + 1);                                // Добавить номер вершины в список нужных. +1, так как вершины хранятся с 0.
                    ++children;                                                 // Добавить количество детей у вершины
                }
            }
            if (parent == -1 && children > 1)                                   // Если это корень, и не все вершины обошли за один цикл, то корень - нужная
                Points.Add(current + 1);                                        // Добавить вершину в список нужных
        }

        public void Find_cutpoints(List<List<int>> edges_)
        {
            Points = new List<int>();
            edges = edges_;
            timer = 0;

            for (int i = 0; i < edges.Count(); i++)
            {
                visited.Add(false);
                pos.Add(-1);
                lowest.Add(-1);
            }

            for (int i = 0; i < edges.Count(); ++i)
            {
                if (!visited[i])
                    Dfs(i);
            }
            
            Points.Sort();
            for (int i = 1; i < Points.Count(); i++)
            {
                if (Points[i] == Points[i - 1])
                {
                    Points.RemoveAt(i);
                    i--;
                }
            }

        }


    }
}
