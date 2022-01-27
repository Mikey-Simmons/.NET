public class program
{
    public static void Main(string[] args)
    {
         System.IO.TextReader reader = System.IO.File.OpenText("sales.csv");
        string line;
        List<Sale> SalesData = new List<Sale>();
        while(!string.IsNullOrWhiteSpace(line = reader.ReadLine()))
        {
            try
            {
                SalesData.Add(new Sale(line));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        reader.Close();
        for(int i = 0; i < SalesData.Count; i++)
        {
            Console.WriteLine($"{i,3}: {SalesData[i]}");
        }
        Console.WriteLine("**************************************************************");
        while (true)
        {
            Console.Write("Type in 2 numbers seperated by a single space from the list above to add together or press return to stop: ");
            line = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(line))
            {
                break;
            }
            string[] data = line.Split(' ');
            if(2 != data.Length)
            {
                Console.WriteLine($"Error...  Invalid format! {line} does not have 2 numbers with a single space in between.  ");
            }
            else
            {
                int one;
                int two;
                if(!int.TryParse(data[0], out one))
                {
                    Console.WriteLine($"The first item of {line} is not an integer"); continue;
                }
                if(!int.TryParse((string)data[1], out two))
                {
                    Console.WriteLine($"Second item of {line} is not an integer"); continue;

                }
                if (two < 0)
                {
                    Console.WriteLine("second item is too low.  must be greater than zero."); continue;
                }
                if(one < 0)
                {
                    Console.WriteLine("first item is too low. must be greater than zero."); continue;
                }
                if(one>= SalesData.Count)
                {
                    Console.WriteLine($"the first item of {line} is too high! must be less than {SalesData.Count}");
                }
                if (two >= SalesData.Count)
                {
                    Console.WriteLine($"the second item of {line} is too high! must be less than {SalesData.Count}");
                }
                Sale first = SalesData[one];
                Sale second = SalesData[two];
                try
                {
                    Sale sum = first + second;
                    Console.WriteLine(sum);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }





}
public class Sale
{
    //employee accessor

    public String Employee
    {
        get;
        set;
    }
    //sales amount accessors
    public decimal SalesAmount
    {
        get;
        set;
    }
    //commission rate accessor

    private decimal CommissionRate;
   


    //commission accessor

    public decimal Commission
    {
        get { return Math.Round(SalesAmount * CommissionRate, 3); }
    }
    //constructor 1
    public Sale(string employeeName, decimal salesAmount, decimal commissionrate)
    {
        this.Employee = employeeName;
        this.SalesAmount = salesAmount;
        this.CommissionRate = commissionrate;

    }
    //constructor 2 
    public Sale(string employeeName, decimal salesAmount)
    {
        this.Employee = employeeName;
this.SalesAmount = salesAmount;
        CommissionRate = 0.03m;

    }
    //constructor 3
    public Sale(string csv)
    {
        string[] data = csv.Split(',');
        if (3 != data.Length)
        {
            throw new Exception($"csv entry {csv} does not have exatcly 3 parts. ");
        }
        Employee = data[0];
        decimal mynum;
        if (!decimal.TryParse(data[1], out mynum))
        {
            throw new Exception($"csv entry {csv} part 2 is not a decimal....");
        }
        SalesAmount = mynum;
        if (!decimal.TryParse((string)data[2], out mynum))
        {
            throw new Exception($"csv entry {csv} part 3 is not a decimal..");
        }
        CommissionRate = mynum;
    }
    //string override method
    public override string ToString()
    {
        return $"Employee: {Employee,10} Sales: {SalesAmount,15:0000.00} Rate:{CommissionRate,10:0.000} Commision: {Commission}";
    }
    // + operator
    public static Sale operator + (Sale left, Sale right)
    {
        if (left.Employee != right.Employee)
        {
            throw new Exception("Left and right employee must be the same!");
        }
        decimal totalSales = left.SalesAmount + right.SalesAmount;
        decimal totalCommish = left.Commission + right.Commission;
        decimal combinedRate = totalCommish / totalSales;
        var dat = new Sale(left.Employee, totalCommish, combinedRate);
        return dat;


        
    }

}