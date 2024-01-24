namespace TempoDeJogoEmMinutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tempo de jogo com Minutos - 7 8 9 10  * O JOGO DUROU 2 HORA(S) E 2 MINUTO(S) * 

            int hora_ini, min_ini, hora_final, min_final, horas_t=0, min_t=0;

            hora_ini = int.Parse(Console.ReadLine());
            min_ini = int.Parse(Console.ReadLine());
            hora_final = int.Parse(Console.ReadLine());
            min_final = int.Parse(Console.ReadLine());

            if ((hora_ini != 0 || min_ini != 0 || hora_final != 0 || min_final != 0) || (hora_ini != hora_final || min_ini <= min_final))
            {
                if (hora_ini == hora_final && min_ini == min_final)
                {
                    horas_t = 24;
                }
                else
                {
                    while (hora_ini != hora_final || min_ini != min_final)
                    {
                        if (min_t == 60)
                        {
                            horas_t++;
                            min_t = 0;
                        }

                        if (min_ini == 60)
                        {
                            hora_ini++;
                            min_ini = 0;
                        }

                        min_t++;
                        min_ini++;
                    }
                }
                
            }
            
            Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horas_t, min_t);     
        }           
    }               
}
