# Matrizes

- Vetor de vetor
- Vetor 2D
- Array bidimensional

```cs
int[][] array = { {1, 2, 3},
                  {4, 5, 6},
                  {7, 8, 9} };

// int[][] array = { {1, 2, 3}, {3, 4, 5}, {5, 6, 7} };

// array[2] = {5 , 6, 7}
// array[linha][coluna]
array[2][2]; // 9
array[0][2]; // 3

double[] alturas = { 1.8, 1.6, 1.7 };
double[] alturas2 = new double[3];
```

## Estudo das posições

- Investir em casos pequenos

```cs
[0, 0] [0, 1]
[1, 0] [1, 1]
```

```cs
[0, 0] [0, 1] [0, 2]
[1, 0] [1, 1] [1, 2]
[2, 0] [2, 1] [2, 2]
```

## Diagonais

- São sempre em matrizes quadradas

diagonal principal:

```cs
[0, 0] [1, 1] [2, 2]
```

Fórmula dos elementos na diagonal principal:

São os elementos nas posições `[i, i]`

