using System.Data;

class Matriz
{
    public static void Main()
    {
        //Matriz Multidimensionais de cargos e funcionario

        string query = ""; // Uma variavel do tipo string recebendo vazio
        int incremento = 0; // Uma variavel do tipo inteiro recebendo valor 0
        string[,] coluna = new string[4, 2];  //Uma matriz de 4 linhas e 2 Colunas

        //Primeira Coluna
        coluna[0, 0] = "CARGO";
        coluna[1, 0] = "Gerente";
        coluna[2, 0] = "Supervisor";
        coluna[3, 0] = "Analista";

        //Segunda Coluna
        coluna[0, 1] = "PESSOAS";
        coluna[1, 1] = "Gustavo";
        coluna[2, 1] = "Bruno";
        coluna[3, 1] = "Mario";
        // Para aumentar a quantidade de colunas altere o (new string[4, 2]), numero 2 pra numero 3 e assim por diante


        //Foi usado um laço de repetição iniciando com 0 ate menor ou igual a 3 para percorrer a matriz
        for (incremento = 0; incremento <= 3; incremento++)
        {
            //a variavel query recebendo ela mesmo para criar a string 
            query = query + $"\r \n {coluna[incremento, 0]} || {coluna[incremento, 1]}";
        }
           // imprimir a string formatada Query no console
        Console.WriteLine(query);


    }
}

//using System.Data;

//class Matriz
//{

//    public static void Main()
//    {
//        string query = "";
//        int inc = 0;
//        string[,] Coluna = new string[4, 2];


//        Coluna[0, 0] = "CARGO";
//        Coluna[1, 0] = "Gerente";
//        Coluna[2, 0] = "Supervisor";
//        Coluna[3, 0] = "Analista";


//        Coluna[0, 1] = "     PESSOAS    ";
//        Coluna[1, 1] = "     João     ";
//        Coluna[2, 1] = "     Mario      ";
//        Coluna[3, 1] = "     Gustavo     ";


//        for (inc = 0; inc <= 3; inc++)
//        {
//            query = query + $"\r \n {Coluna[inc, 0]} || {Coluna[inc, 1]}";
//        }
//        Console.WriteLine(query);


//    }
//}
