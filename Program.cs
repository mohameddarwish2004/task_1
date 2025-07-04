// See https://aka.ms/new-console-template for more information
Console.WriteLine("Estimate for carpet cleaning service");
Console.WriteLine("what is Number of small carpets:");
int Smallcarpenter = Convert.ToInt32( Console.ReadLine());
Console.WriteLine("what is Number of large carpets:");
int Largecarpenter = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Price per small room: $25\r\nPrice per large room: $35\r\n");
int Cost = Smallcarpenter * 25 + Largecarpenter * 35;
Console.WriteLine("cost=$"+Cost);
double tax = Cost * 0.06;
Console.WriteLine("tax=" + tax);
double Totalcost = Cost + tax;
Console.WriteLine("total cost =$"+Totalcost);
Console.WriteLine("This estimate is valid for 30 days");


