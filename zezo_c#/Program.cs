Console.WriteLine("Hello,user");
Console.Write("How many small rugs do you want to wash:");
int small=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("price per small room: $250");
Console.Write("How many large rugs do you want to wash:");
int large=Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("price per large room: $350");
Console.WriteLine($"cost: {small*250+large*350}");
Console.WriteLine($"tax: {(small*250+large*350)*0.14}");
Console.WriteLine("===========================");
Console.WriteLine($"total estimate: {((small*250+large*350)*0.14)+(small*250+large*350)}");
Console.WriteLine("this estimate is valid for 30 days.");



