using System;

namespace ConsoleAppInheritanceDemo
{
    class Student
    {
        string Firstname, Identity;
        public Student(string firstname, string identity)
        {
            this.Firstname = firstname;
            this.Identity = identity;
        }
        ~Student()
        { }
    }
        class HotelStudent : Student
        {
            int RoomNo;
            public HotelStudent(string firstname, string identity,int roomno):base(firstname,identity)
            {
                this.RoomNo=roomno;
                PrintDetails(firstname, identity, roomno);
            }

            public void PrintDetails(string firstname, string identity, int roomno)
            {
                Console.WriteLine("Student Details : ");
                Console.WriteLine();
                Console.WriteLine(" FirstName : " + firstname);
                Console.WriteLine(" Identity : " + identity);
                Console.WriteLine(" Room Number : " + roomno);
            }
        }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance with constructor & destructor");
            Console.WriteLine("===========================================");
            new HotelStudent("ABC","MH24",12);

            
        }
    }
}
