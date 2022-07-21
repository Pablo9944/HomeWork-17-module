
using HomeWork_17_module;
using HomeWork_17_module.choice;

class Program
{
    static void Main()
    {
        // Напишите свой вариант рефакторинга кода из задания 4 в соответствии с Принципом открытости-закрытости.


        Account accountOrdinaly = new Account() { Interest = 100.00, Balance = 50000.00, Type = "Ordinaly" };
        IOrdinary ordinaly = accountOrdinaly;
        ordinaly.CalculateInterest();

        Account accountSalary = new Account() { Interest = 1000.00, Balance = 5000.00, Type="Salary"};
        ISalary salary = accountSalary;
        salary.CalculateInterest();


        Calculator.CalculateInterest(accountOrdinaly);

        Calculator.CalculateInterest(accountSalary);
    }
}