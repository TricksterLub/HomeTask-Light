using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {   
        enum Status
        {
            светло=1,
            темно=2,
            не_зименено=3
        }
        static void Main(string[] args)
        {   string input = string.Empty;
            int condition =(int)Status.не_зименено;
            int sostoanie;
            Random rand = new Random(); 
            sostoanie=rand.Next(2)+1;
            switch(sostoanie)
            {
                case 1:
                    Console.WriteLine($"В комнате {Status.светло}.");
                    condition =(int)Status.светло;
                    Console.WriteLine($"Для изменения состояния введите {Status.темно} или {(int)Status.темно}.");
                    break;
                case 2:
                    Console.WriteLine($"В комнате {Status.темно}.");
                    condition = (int)Status.темно;
                    Console.WriteLine($"Для изменения состояния введите {Status.светло} или {(int)Status.светло}.");
                    break;
            }
            Console.WriteLine($"Если вы не введёте ни одно из состояний изменения, либо введёте не корректно, то состояние не поменятеся.");
            Console.WriteLine($"Если же вы не хотите менять состояние, то введите {Status.не_зименено} или {(int)Status.не_зименено}");
            input=Console.ReadLine();
            string y = $"{condition}";
            Status stat = (Status)int.Parse(y);
            y = $"{stat}";
            if (y != input)
            {
                switch (input)
                {
                    case "темно":
                        Console.WriteLine($"Состояние в комнате {Status.темно}");
                        break;
                    case "светло":
                        Console.WriteLine($"Состояние в комнате {Status.светло}");
                        break;
                    default:
                        bool logica = int.TryParse(input, out int inp);

                        switch (logica)
                        {
                            case true:
                                if (inp != condition) {
                                    switch (inp)
                                    {
                                        case 1:
                                            Console.WriteLine($"Состояние {Status.светло}");
                                            break;
                                        case 2:
                                            Console.WriteLine($"Состояние {Status.темно}");
                                            break;
                                        case 3:
                                            Console.WriteLine($"Состояние {Status.не_зименено}");
                                            break;
                                            default :
                                            Console.WriteLine($"Состояние {Status.не_зименено}");
                                            break;
                                    }
                                    
                                }else
                                {
                                    Console.WriteLine($"Состояние {Status.не_зименено}");
                                }
                                break;
                            default:
                                Console.WriteLine($"Состояние {Status.не_зименено}");
                                    break;
                        }
                        break;
                }
            } else {
                Console.WriteLine($"Состояние {Status.не_зименено}");
                    }
        }
    }
}