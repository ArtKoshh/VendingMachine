using VendingMachineUppgift;

var vendingMachine = new VendingMachine();
while (!vendingMachine.checkTotal())
{
    Console.WriteLine("                                            <******************************>");
    Console.WriteLine("Please Enter valid amount of Coins or Sedel <^> 1, 5, 10, 20, 50 ,100 KR <^>");
    Console.WriteLine("                                            <******************************>");
    vendingMachine.DepositMoney(Convert.ToInt32(Console.ReadLine()));
}
vendingMachine.DisplaySelection();


Console.ReadLine();