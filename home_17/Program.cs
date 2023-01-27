using System;
string s;
list_tem list_Tem = new list_tem();
do
{
    Console.WriteLine("Press 1 to create a voting topic");
    Console.WriteLine("Press 2 to vote");
    Console.WriteLine("Press 3 to see the voting results");
    s = Console.ReadLine();
    switch (s)
    {
        case "1":
            Console.WriteLine("Write name:");
            string str = Console.ReadLine();
            list_Tem.add(str);
            break;
        case "2":
            list_Tem.printall();
            Console.Write("write number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            list_Tem.addvote(n);
            break;
        case "3":
            list_Tem.printall();
            break;
    }
} while (s != "0");

class tem
{
    public string name = "";
    public int n;
}

class list_tem
{
    List<tem> str = new List<tem>();
    public void add(string s)
    {
        tem t = new tem();
        t.name = s;
        t.n = 0;
        str.Add(t);

    }

    public void printall()
    {
        int n = 0;
        foreach (tem i in str)
        {
            Console.WriteLine(n + ".Name: " + str[n].name + " Number of votes: " + str[n].n);
            n++;
        }
    }

    public void addvote(int n)
    {
        str[n].n++;
    }
}