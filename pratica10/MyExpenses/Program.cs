class Program {
  public static void Main() {
    // exemplo de array multidimensional
    /* importantr lembrar que, i primeiro valor informado ao instanciar (2)
    refere-se a quantidade de dimensões que o seu array terá, ou seja,
    duas chaves(duas posições). Já o segundo valor (3) refere-se a quantidade
    de valores que cada uma das dimensões irão receber, sendo então o tatal
    de três valores (três posições) */
    int[,] myArray = new int[2, 2] {
      { 1, 2 },
      { 3, 4 }
    };

    /* o valor informado como parâmetro para o método GetLength refere-se
    a dimensão que deseja visualizar, ou seja, a posição do seu array
    dimensional, sendo nesse caso, o tamanho da primeira dimensão (2) 
    que é a posição 0 do array. Caso fosse informado o parâmetro 1, o
    tamanho da segunda dimensão (3) que é a posição 1 do array */
    // Console.WriteLine(myArray.GetLength(0));

    int result = GetSumDiagonal(myArray);
    Console.WriteLine(result);
  }

  public static int GetSumDiagonal(int[,] matrix) {
    int sum = 0;

    /* vai percorrer a quantidade de dimensões pertencentes ao array matrix
    ou seja, da quantidade de linhas do array. */
    for (int i = 0; i < matrix.GetLength(0); i++) {
      sum += matrix[i, i];
    }

    return sum;
  }
}