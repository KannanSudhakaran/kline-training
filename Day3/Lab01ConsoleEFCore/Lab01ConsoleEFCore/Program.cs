
using Lab01ConsoleEFCore.Data;
using Lab01ConsoleEFCore.Domain;

//CaseStudy1();
//CaseStudy2();

//CaseSTudy3();

CaseStudy4();

void CaseStudy4()
{
    var db = new KlineAppDbContext();
    var customersQuery= db.Customers
                           // .ToList()
                            .Where(c => c.FirstName
                                         .Split()[1]
                                         .Contains("a"));

    var customerLastNamwithA = customersQuery.FirstOrDefault();

    Console.WriteLine(customerLastNamwithA);


}

void CaseSTudy3()
{
    //all customer name container Y
    var db = new KlineAppDbContext();
    var customerNameWithY = db.Customers
                             // .ToList()
                              .Where(c => c.FirstName.Contains("Y"));

    var firstCustomorWithY = customerNameWithY.FirstOrDefault();
    Console.WriteLine(firstCustomorWithY);

}

void CaseStudy2()
{
    var db = new KlineAppDbContext();
    var customers= db.Customers;//deferred execution
    //immediate execution
   // var customersList= db.Customers.ToList();

    foreach (var customer in customers)
    {
        Console.WriteLine($"Id:{customer.Id}, FirstName:{customer.FirstName}");
    }

}

void CaseStudy1()
{
    
    var c1 = new Customer
    {
        FirstName = "Yi Jing"
    };
    var c2 = new Customer
    {
        FirstName = "Yi Hao"
    };
    var c3 = new Customer
    {
        FirstName = "Lin Jing"
    };

    var db = new KlineAppDbContext();
    db.Customers.Add(c1);
    db.Customers.Add(c2);
    db.Customers.Add(c3);
    db.SaveChanges();
    Console.WriteLine("end of casestudy1");

}