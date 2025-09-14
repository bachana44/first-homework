using System.Diagnostics;

namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ავტორიზაცია(Login Authentication) 1




            //Console.Write("Username: ");
            //string userName = Console.ReadLine();
            //Console.Write("Password: ");
            //string password = Console.ReadLine();

            //Console.Write("for login use your Username: ");
            //string checkedUserName = Console.ReadLine();
            //Console.WriteLine("Password: ");
            //string checkedPassword = Console.ReadLine();
            //if (checkedUserName == userName && checkedPassword == password)
            //{
            //    Console.WriteLine("Login Successful!");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid credentials!");
            //}







            //ქულების მიხედვით შეფასება(Grade Calculator) 2


            //Console.Write("Student name: ");
            //string studentName = Console.ReadLine();
            //Console.Write("What grade did u get in test?:  ");
            //int grade = Convert.ToInt32(Console.ReadLine());

            //if (grade >= 90 && grade <= 100)
            //{
            //    Console.WriteLine($"{studentName} shen qulaa ({grade}) shen miige A+");
            //} else if (grade >= 80 && grade <= 89)
            //{
            //    Console.WriteLine($"{studentName} shen qulaa ({grade}) shen miige A");
            //} else if (grade >=70 && grade <=79)
            //{
            //    Console.WriteLine($"{studentName} shen qulaa ({grade}) shen miige B");
            //} else if (grade <70 && grade >= 0)
            //{
            //    Console.WriteLine($"{studentName} shen qulaa ({grade}) shen miige C");
            //} else
            //{
            //    Console.WriteLine("sheni chawerili qula ar sheesabameba realobas");
            //}



            //ფასდაკლების გამოთვლა(Discount Calculation) 3

            //Console.WriteLine("tanxis raodenoba: ");
            //int amount = Convert.ToInt32(Console.ReadLine());

            //if (amount > 1000)
            //{
            //    int finalPrice = amount - ((amount * 10) / 100);
            //    Console.WriteLine($"tqven gekutvnit 10% fasdakleba, saboloo fasi {finalPrice}");    


            //} else if (amount >0 && amount <= 1000) {

            //    int finalPrice = amount - ((amount * 5) / 100);
            //    Console.WriteLine($"tqven gekutvnit 10% fasdakleba, saboloo fasi {finalPrice}");
            //}
            //else
            //{
            //    Console.WriteLine("tqven mier shemoyvanili tanxa ar sheesabameba realobas");
            //}





            //კვირის დღეები(Day of the Week) 4

            //Console.WriteLine("sheiyvanet ricxvi?: ");
            //int userInput = Convert.ToInt32(Console.ReadLine());

            //if (userInput == 1)
            //{
            //    Console.WriteLine("Monday");
            //} else if (userInput == 2)
            //{
            //    Console.WriteLine("Tuesday");
            //}
            //else if (userInput == 3)
            //{
            //    Console.WriteLine("Wednesday");
            //}
            //else if (userInput == 4)
            //{
            //    Console.WriteLine("Thursday");
            //}
            //else if (userInput == 5)
            //{
            //    Console.WriteLine("Friday ");
            //}
            //else if (userInput == 6)
            //{
            //    Console.WriteLine("Saturday");
            //}
            //else if (userInput == 7)
            //{
            //    Console.WriteLine("Sunday");
            //} else
            //{
            //    Console.WriteLine(""Invalid day number"");
            //}






            //შუქნიშანი(Traffic Light System) 5

            //Console.WriteLine("signal 'Red', 'Yellow', 'Green': ");
            //string signal = Console.ReadLine().ToLower();

            //if (signal == "red")
            //{
            //    Console.WriteLine("Stop!");
            //} else if(signal == "yellow")
            //{
            //    Console.WriteLine("Get Ready!");
            //} else if (signal == "green")
            //{
            //    Console.WriteLine("Go!");
            //} else
            //{
            //    Console.WriteLine("Invalid signal");  
            //}




            //ბანკომატი(ATM Withdrawal Validation) 6





            //Console.WriteLine("Balance: ");
            //int balance = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Withdrawal: ");
            //int Withdrawal = Convert.ToInt32(Console.ReadLine());

            //if(balance < 0)
            //{
            //    Console.WriteLine("Invalid withdrawal amount");
            //} else if (balance < Withdrawal)
            //{
            //    Console.WriteLine("Insufficient balance");
            //} else
            //{
            //    Console.WriteLine("Withdrawal successful! Remaining balance: ...");
            //}







            //სტუდენტის ჩაჭრა/ ჩაბარება(Pass / Fail Result) 7 




            //Console.WriteLine("Student name: ");
            //string studentName = Console.ReadLine();
            //Console.WriteLine("Score: ");
            //int score = Convert.ToInt32(Console.ReadLine());

            //if (score >= 50 && score <= 100)
            //{
            //    Console.WriteLine($"{studentName} u passed");
            //}else if (score < 50 && score >=0)
            //{
            //    Console.WriteLine($"{studentName} u failed");
            //}else
            //{
            //    Console.WriteLine("invalid score");
            //}






            //კალკულატორი(Calculator Program) 8



            //Console.WriteLine("first number: ");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("second number: ");
            //int secondNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("operation '+', '-', '/', '*': ");
            //string operation = Console.ReadLine();
            //int result; 

            //if (operation == "+")
            //{
            //    result = firstNumber + secondNumber;
            //    Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
            //} else if (operation == "-")
            //{
            //    result = firstNumber - secondNumber;
            //    Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
            //}
            //else if (operation == "/")
            //{
            //    result = firstNumber / secondNumber;
            //    Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
            //}
            //else if (operation == "*")
            //{
            //    result = firstNumber * secondNumber;
            //    Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
            //} else
            //{
            //    Console.WriteLine("invalid operation");
            //}




            //ხმის მიცემის უფლება(Voting Eligibility) 9



            //Console.WriteLine("age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //if (age < 0)
            //{
            //    Console.WriteLine("Invalid age");
            //}else if (age >= 18)
            //{
            //    Console.WriteLine("Eligible to vote");
            //} else
            //{
            //    Console.WriteLine("Not eligible to vote");
            //}





            //თანამშრომლის ბონუსი(Employee Bonus Calculation) 10




            //Console.WriteLine("role ('Manager', 'Developer', or else)");
            //string role = Console.ReadLine().ToLower();
            //Console.WriteLine("Salary: ");
            //int salary = Convert.ToInt32(Console.ReadLine());

            //if (role == "manager" && salary > 2500)
            //{
            //    int bonus = (salary * 15) / 100;
            //    Console.WriteLine($"Tqven gekutvnit {bonus} bonusi");
            //}
            //else if (role == "manager" && salary <= 2500)
            //{
            //    int bonus = (salary * 10) / 100;
            //    Console.WriteLine($"Tqven gekutvnit {bonus} bonusi");
            //}
            //else if (role == "developer" && salary > 2000)
            //{
            //    int bonus = (salary * 12) / 100;
            //    Console.WriteLine($"Tqven gekutvnit {bonus} bonusi");
            //}
            //else if (role == "developer" && salary <= 2000)
            //{
            //    int bonus = (salary * 8) / 100;
            //    Console.WriteLine($"Tqven gekutvnit {bonus} bonusi");
            //} else
            //{
            //    int bonus = (salary * 5) / 100;
            //    Console.WriteLine($"Tqven gekutvnit {bonus} bonusi");
            //}

        }
    }
} 
