# PEA-tabu-search

Tabu search algorithm made to solve Travelling Salesman Problem. Project was made for studies. Used C# for implementation.

Algorithm can be run with following edge weight types:
* EUC_2D for TSP
* FULL_MATRIX for ATSP

TSP problem instances can be downloaded from: http://comopt.ifi.uni-heidelberg.de/software/TSPLIB95/tsp/

ATSP problem instances can be downloaded form: http://comopt.ifi.uni-heidelberg.de/software/TSPLIB95/atsp/

## Tabu list size
Size of tabu list is set to 5.

## Types of neighbourhood used in project:
* Swap - swaps 2 random cities in path
* Insert - picks 1 random city and puts it in another random location in path
* Invert - pics 2 random cities and inverts path between them, including those cities, in path
