using System;

namespace Assigment
{   
    class Customer{
        public string Name;
        public int ID;
        public string Email;
        public long Telephone;
        public Customer(string Name ,int ID ,string Email,long Telephone){
            this.Name = Name;
            this.ID = ID;
            this.Email = Email;
            this.Telephone = Telephone ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Customer customer1 = new Customer ("Edward", 706, "Edward@gmail.com" , +2347034471694);
            Console.WriteLine();

            Customer customer2 = new Customer ("Benard", 800, "Benard@gmail.com" , +2349034471694);
            Console.WriteLine(customer2.ID);

            Customer customer3 = new Customer ("Frank", 801, "Frank@gmail.com" , +2348034471694);
            Console.WriteLine(customer3.Telephone);

            Customer customer4 = new Customer ("Desmond", 661, "Desmond@gmail.com" , +23481034471694);
            Console.WriteLine();

            Customer customer5 = new Customer ("Richard", 946, "Richard@gmail.com" , +2349066471694);
            Console.WriteLine(customer5.Telephone);


            Console.Write("Enter a Number: ");
            string nam = "Stop";
            int number = Convert.ToInt32(Console.ReadLine());
            while((number % 2) == 0){
                Console.Write("Enter a Number: ");
                Console.ReadLine();
                Console.WriteLine("true");
            }
            if((number % 2) != 0){
                Console.WriteLine("false");
                Console.Write("Enter a Number: ");
                Console.ReadLine();
            }else if (nam  !=nam){
                Console.Write("Enter a Number: ");
            }else if (nam  == nam){
                Console.WriteLine("Stop");
            }
            // string[] areas ={"Lagos","anambra","enugu","Kwara","Edo","Bariga","kosofe","shomulo","moshin","ikeja","Yaba"};

            // foreach(string Allareas in areas){
            //     if (Allareas.Contains("a")){
            //         Console.WriteLine(Allareas);
            //     }
            // } 

            // int[] nums = {1,2,3,4,5,6,7,8,9,11,12,13,14,15,16,17,18,19,21,22};
            // int total = 0;
            // foreach(var num in nums){
            //     if(num %3 == 0){
            //         total += num;
            //     }
            // }Console.WriteLine(total);

            // Console.WriteLine("Today is\n Monday");
            // Console.WriteLine("S\\N\tName\t\tState");

            // string [] names = {"ayo", "promise", "femi", "fuad", "hammed"};
            // string [] states = {"Lagos", "anambra", "enugu"," Kwara", "Edo"};

            // var i = 0;
            // foreach (var name in names){
            //     Console.WriteLine($"{i + 1}\t{name}\t\t{states[i]}");
            //     i++;
            // }

            // // Console.Write("Please Enter your name: ");
            // // string myName = Console.ReadLine();

            // // Console.WriteLine(" Enter your age: ");
            
            // // try{
            // //     int myAge = int.Parse(Console.ReadLine());
            // //     Console.WriteLine($"hello {myName} you are {myAge} yearsOld");
            // // }catch(Exception e){
            // //     Console.WriteLine(e.Message);
            // // }

            

        }
    }
}
