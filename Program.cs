Console.Clear();

int adultoalcool = 0, adulto = 0, totaladultos, crianca = 0, todos = 0 ;
double carne = 0.0, acompanhamentos =0.0, cerveja = 0.0, refrigerante = 0.0 , agua = 0.0;
 
Console.WriteLine("--- Vamos calcular a quantidade de itens necessários para o churrasco. ---");
 
Console.WriteLine("Indique a quantidade de adultos que consomem álcool:");
adultoalcool = Convert.ToInt32(Console.ReadLine()!);
 
Console.WriteLine("Indique a quantidade de adultos que não consomem álcool:");
adulto = Convert.ToInt32(Console.ReadLine()!);
 
Console.WriteLine("Indique a quantidade de crianças:");
crianca = Convert.ToInt32(Console.ReadLine()!); 

totaladultos = adultoalcool + adulto;
todos = adultoalcool + adulto + crianca;
 
carne = 0.4 *  totaladultos + (0.2 * crianca);
acompanhamentos = 0.2 * (totaladultos + crianca);

cerveja = 2 * adultoalcool;

refrigerante = 0.5  * (adulto + crianca);
agua = 0.4 * todos;
 
Console.WriteLine("--- Churrasco ---");
 
Console.WriteLine($"Adultos (que consomem bebidas alcoólicas).......: {adultoalcool}");
 
Console.WriteLine($"Adultos (que não consomem bebidas alcoólicas)...: {adulto}");
 
Console.WriteLine($"Crianças........................................: {crianca}");
 
Console.WriteLine($"Carne.............: {carne :N1} kg");
 
Console.WriteLine($"Acompanhamentos...: {acompanhamentos :N1} kg");
 
Console.WriteLine($"Cerveja...........:{cerveja :N1} l");

Console.WriteLine($"Refrigerante......:{refrigerante :N1} l");

Console.WriteLine($"Água..............:{agua :N1} l");
