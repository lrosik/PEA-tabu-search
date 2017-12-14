using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TabuSearch
{
    public class Graph
    {
        public List<List<double>> Matrix { get; set; }
        public double SolutionDistance { get; set; }
        public List<int> SolutionVertices { get; set; }
        
        public List<int> FindGreedyPath()
        {
            var verticesList = new List<int>();         // lista wierzchołków należących do ścieżki
            var visitedVertices = new List<int>(Matrix.Count);    // lista odwiedzonych wierzchołków, 1 oznacza odwiedzony, 0 nie

            for (int i = 0; i < Matrix.Count; i++)
            {
                visitedVertices.Add(0);
            }

            verticesList.Add(0);    // dodanie punktu startowego
            visitedVertices[0] = 1; // oznaczenie punktu startowego jako odwiedzony

            var index = 0;

            for (int i = 0; i < Matrix.Count-1; i++)
            {
                var row = Matrix[index];
                double min = int.MaxValue;

                for (int j = 0; j < row.Count; j++)
                {
                    var item = row[j];

                    if (visitedVertices[j] == 0 && item < min && j != index)
                    {
                        min = item;
                        index = j;
                    }
                }

                verticesList.Add(index);
                visitedVertices[index] = 1;
            }

            verticesList.Add(0); // dodanie punktu początkowego jako powrót

            return verticesList;
        }

        public double RunSwapTabuSearch(int time, int tabuSize)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            SolutionVertices = FindGreedyPath();
            SolutionDistance = CalculateDistance(SolutionVertices);

            var bestCandidate = new List<int>(SolutionVertices);
            var bestCandidateDistance = SolutionDistance;

            var tabuList = new List<(int, int)>();

            var stoppingCondition = false;
            var iterations = 0;

            while (!stoppingCondition)
            {
                var foundBetter = false;

                for (int i = 1; i < bestCandidate.Count - 2; i++)
                {
                    for (int j = i + 1; j < bestCandidate.Count - 1; j++)
                    {
                        if (!tabuList.Contains((bestCandidate[i], bestCandidate[j])) || !tabuList.Contains((bestCandidate[j], bestCandidate[i])))
                        {
                            var tempList = new List<int>(bestCandidate);
                            var temp = tempList[i];
                            tempList[i] = tempList[j];
                            tempList[j] = temp;

                            var distance = CalculateDistance(tempList);

                            if (distance < bestCandidateDistance)
                            {
                                bestCandidate = new List<int>(tempList);
                                bestCandidateDistance = distance;
                                var bestMove = (bestCandidate[i], bestCandidate[j]);
                                tabuList.Add(bestMove);

                                if (tabuList.Count > tabuSize)
                                {
                                    tabuList.RemoveAt(0);
                                }

                                foundBetter = true;
                                iterations = 0;
                            }
                        }
                    }
                }

                //if (!foundBetter)
                //    iterations++;

                if (iterations > 3 || stopwatch.ElapsedMilliseconds / 1000 >= time)
                    stoppingCondition = true;
            }

            SolutionVertices = bestCandidate;
            SolutionDistance = bestCandidateDistance;

            stopwatch.Reset();

            return bestCandidateDistance;
        }

        public double RunInsertTabuSearch(int time, int tabuSize)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            SolutionVertices = FindGreedyPath();
            SolutionDistance = CalculateDistance(SolutionVertices);

            var bestCandidate = new List<int>(SolutionVertices);
            var bestCandidateDistance = SolutionDistance;

            var tabuList = new List<(int, int)>();

            var stoppingCondition = false;
            var iterations = 0;

            while (!stoppingCondition)
            {
                var foundBetter = false;

                for (int i = 1; i < bestCandidate.Count - 2; i++)
                {
                    for (int j = 1; j < bestCandidate.Count - 1; j++)
                    {
                        var tempList = new List<int>(bestCandidate);

                        if (i != j && !tabuList.Contains((bestCandidate[i], bestCandidate[j])))
                        {
                            var tmp = tempList[i];
                            tempList.RemoveAt(i);
                            tempList.Insert(j, tmp);
                            var distance = CalculateDistance(tempList);

                            if (distance < bestCandidateDistance)
                            {
                                bestCandidate = new List<int>(tempList);
                                bestCandidateDistance = distance;
                                var bestMove = (bestCandidate[i], bestCandidate[j]);
                                tabuList.Add(bestMove);

                                if (tabuList.Count > tabuSize)
                                {
                                    tabuList.RemoveAt(0);
                                }

                                foundBetter = true;
                                iterations = 0;
                            }
                        }
                    }
                }

                //if (!foundBetter)
                //{
                //    iterations++;
                //}

                if (iterations >= 3 || stopwatch.ElapsedMilliseconds/1000 >= time)
                    stoppingCondition = true;
            }

            SolutionVertices = bestCandidate;
            SolutionDistance = bestCandidateDistance;

            stopwatch.Reset();

            return bestCandidateDistance;
        }

        public double RunInvertTabuSearch(int time, int tabuSize)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            SolutionVertices = FindGreedyPath();
            SolutionDistance = CalculateDistance(SolutionVertices);

            var bestCandidate = new List<int>(SolutionVertices);
            var bestCandidateDistance = SolutionDistance;

            var tabuList = new List<(int, int)>();

            var stoppingCondition = false;
            var iterations = 0;

            while (!stoppingCondition)
            {
                var foundBetter = false;

                //for (int i = 1; i < bestCandidate.Count - 5; i++)
                //{
                //    for (int j = bestCandidate.Count - 2; j > i + 3; j--)
                //    {
                //        var tempList = new List<int>(bestCandidate);

                //        if (!tabuList.Contains((bestCandidate[i], bestCandidate[j])))
                //        {
                //            for (int k = i + 1, l = j - 1, m = 0; m < (l - k + 1)/2; k++, l--, m++)
                //            {
                //                var tmp = tempList[k];
                //                tempList[k] = tempList[l];
                //                tempList[l] = tmp;
                //            }
                //            var distance = CalculateDistance(tempList);

                //            if (distance < bestCandidateDistance)
                //            {
                //                bestCandidate = new List<int>(tempList);
                //                bestCandidateDistance = distance;
                //                var bestMove = (bestCandidate[i], bestCandidate[j]);
                //                tabuList.Add(bestMove);

                //                if (tabuList.Count > 10)
                //                {
                //                    tabuList.RemoveAt(0);
                //                }

                //                foundBetter = true;
                //                iterations = 0;
                //            }
                //        }
                //    }
                //}

                for (int i = 1; i < bestCandidate.Count - 5; i++)
                {
                    for (int j = i + 3; j < bestCandidate.Count - 1; j++)
                    {
                        var tempList = new List<int>(bestCandidate);

                        if (!tabuList.Contains((bestCandidate[i], bestCandidate[j])))
                        {
                            for (int k = i + 1, l = j - 1, m = 0; m < (l - k + 1) / 2; k++, l--, m++)
                            {
                                var tmp = tempList[k];
                                tempList[k] = tempList[l];
                                tempList[l] = tmp;
                            }
                            var distance = CalculateDistance(tempList);

                            if (distance < bestCandidateDistance)
                            {
                                bestCandidate = new List<int>(tempList);
                                bestCandidateDistance = distance;
                                var bestMove = (bestCandidate[i], bestCandidate[j]);
                                //tabuList.Add(bestMove);

                                if (tabuList.Count > tabuSize)
                                {
                                    tabuList.RemoveAt(0);
                                }

                                foundBetter = true;
                                iterations = 0;
                            }
                        }
                    }
                }

                //if (!foundBetter)
                //{
                //    iterations++;
                //}

                if (iterations >= 3 || stopwatch.ElapsedMilliseconds / 1000 >= time)
                    stoppingCondition = true;
            }

            SolutionVertices = bestCandidate;
            SolutionDistance = bestCandidateDistance;

            stopwatch.Reset();

            return bestCandidateDistance;
        }
        
        public double CalculateDistance(List<int> list)
        {
            var sum = 0.0;

            for (int i = 0; i < Matrix.Count; i++)
            {
                sum += Matrix[list[i]][list[i + 1]];
            }

            return sum;
        }

        public void WritePath(List<int> list)
        {
            foreach (var vertex in list)
            {
                Console.Write(vertex + " ");
            }
            Console.WriteLine();
        }
    }
}
