//Calcule o consumo médio de um automóvel sendo fornecidos a distância total percorrida (em Km)
//e o total de combustível gasto (em litros).

double distanciatotal, combustivelgasto, consumomedio;

distanciatotal = double.Parse(Console.ReadLine());
combustivelgasto = double.Parse(Console.ReadLine());
consumomedio = distanciatotal / combustivelgasto;

Console.WriteLine(consumomedio.ToString("F3") + "km/l");