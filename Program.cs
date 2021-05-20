using System;

namespace AulaPOOCelular_1905
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular();

            do{
            } while(celular.ligado == true);
            Console.WriteLine("Aperte 'L' para ligar celular, e 'D' para cancelar");
            string ligarOuDesligar = Console.ReadLine().ToUpper();

            if (ligarOuDesligar == "L")
            {
                celular.Ligar();
            }
            do
            {
                if (celular.ligado == true)
                {
                    Console.WriteLine(@"
|=================================================|
|=================================================|
|                   Bem Vindo!                    |
|             1 - Fazer Ligação                   |
|             2 - Enviar uma mensagem             |
|             3 - Informações                     |
|             4 - Desligar                        |
|=================================================|
|=================================================|
                ");
                    int opcaoMenu = int.Parse(Console.ReadLine());

                    switch (opcaoMenu)
                    {
                        case 1:
                            Console.WriteLine(celular.FazerLigacao());
                            Console.WriteLine($@"
|=================================================|
|=================================================|
|                                                 |
|                                                 |
|             Qual Número deseja ligar?           |
|                                                 |
|                                                 |
|=================================================|
|=================================================|
                            ");
                            string telefoneLigar = Console.ReadLine();

                            Console.WriteLine($@"
|=================================================|
|=================================================|
|                                                 |
|                                                 |
|       Ligando Para o numero {telefoneLigar}       |
|                                                 |
|                                                 |
|=================================================|
|=================================================|
                            ");

                            Console.WriteLine($@"
|=================================================|
|=================================================|
|                                                 |
|                O numero:                        |
|             {telefoneLigar}            |          
|           não atendeu a ligação                 |
|                                                 |
|                                                 |
|=================================================|
|=================================================|
                            ");
                            break;
                        case 2:
                            Console.WriteLine(celular.EnviarMensagem());
                            Console.WriteLine($@"
|=================================================|
|=================================================|
|                                                 |
|                                                 |
|     Qual numero deseja enviar uma mensagem?     |
|                                                 |
|                                                 |
|=================================================|
|=================================================|
                            ");
                            string telefoneMensagem = Console.ReadLine();

                            Console.WriteLine($@"
|=================================================|
|=================================================|
|                                                 |
|                                                 |
|              Escreva sua mensagem:              |
|                                                 |
|                                                 |
|                                                 |
|=================================================|
|=================================================|
                            ");
                            string mensagem = Console.ReadLine();

                            Console.WriteLine($@"
|=================================================|
|=================================================|
|                                                 |
|      Enviada para:                              |
|      {telefoneMensagem}                         |
|                                                 |
|      '{mensagem}'                               |
|                                                 |
|                                                 |
|                                                 |
|=================================================| 
|=================================================| 
 
                            ");
                            break;
                        case 3:
                            Console.WriteLine($@"
|=================================================|
|=================================================|
|             Informações                         |
|                                                 |
|             Modelo: {celular.modelo}         |
|             Cor: {celular.cor}                          |
|             tamanho em cm: {celular.tamanho}                   |
|                                                 |
|=================================================|
|=================================================|
                ");
                            break;

                        case 4:
                            celular.Desligar();
                            break;
                    }
                }
            } while (celular.ligado == true);

        }
    }
}
