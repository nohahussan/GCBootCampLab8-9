using System;
using System.Collections.Generic;

namespace Lab8_9
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Student> Students = new List<Student> //create list of c# students
            {
                new Student () { name = "Noha Hussan", homeTown = "Windsor" , favoriteFood = "Pasta" },
                new Student () { name = "Evan Simon", homeTown = "Waterville Ohio" , favoriteFood = "Grilled Octopus" },
                new Student () { name = "Ronald Lemuel", homeTown = "Lincoln Park", favoriteFood = " Saganaki" },
                new Student () { name = "Laura Huie", homeTown = "Albuquerque", favoriteFood = " Bibimbap" },
                new Student () { name = "Levi Sims", homeTown = "DETROIT", favoriteFood = " Pizza" },
                new Student () { name = "Kentdavidbutler", homeTown = "Sterling Heights", favoriteFood = " Pizza" },
                new Student () { name = "Justin Sortor", homeTown = " Warren, MI", favoriteFood = "Quesadillas" },
                new Student () { name = "Steve Webster", homeTown = "Perrysburg, OH", favoriteFood = "Pizza" },
                new Student () { name = " Kendra Diamond", homeTown = "Oak Park, MI", favoriteFood = "veggie burger & fries" },
                new Student () { name = "Karrar Aldhalimi", homeTown = "San Diego, California", favoriteFood = "Burger" },

            };
            Students.Sort(); //sort the list
            Console.WriteLine("List of all student in c# class:");
            foreach (Student s in Students)//print all the students in c# class
            {
                Console.WriteLine("Name: "+s.name +"  HomeTown: "+s.homeTown+" Favorite Food: "+s.favoriteFood);
            }
            Console.WriteLine();
            Boolean repeat = true;
            while(repeat)
            {
                Console.WriteLine("Hello Please if you would like to add a new student in the list\n" +
                	" please enter (add) \n" +
                	"If you like to find out information about one a student \n" +
                	"please enter (search)\n" +
                	"or enter (exit to exit the program)");
                string userChoice = "";
                try
                {
                    userChoice = Console.ReadLine().ToLower();
                    if (userChoice == "exit")
                    {
                        repeat = false;
                        break;
                    }
                    else if(userChoice == "search")//searching
                    {
                        string name = "";
                        string result = "";
                        try
                        {
                            Console.WriteLine("Please enter a student name : ");
                            name = Console.ReadLine();
                            if (name != "")
                            {

                                result = SearchStudent(name, Students);
                                if(result == "-1")
                                {
                                    Console.WriteLine("Sorry this student is not in the list!!");
                                }
                                else
                                {
                                    Console.WriteLine(result);
                                    Console.WriteLine();
                                }
                            }
                            else 
                            {
                                throw new Exception("unvalid input");
                            }
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                            repeat= true;
                        }
                    }
                    else if (userChoice == "add")//adding new student
                    {
                        string name = "";
                        String homeTown = "";
                        String FavoriteFood = "";
                        try
                        {
                            Console.WriteLine("Please enter a name : ");
                            name = Console.ReadLine();
                            Console.WriteLine("Please enter a Hometown : ");
                            homeTown = Console.ReadLine();
                            Console.WriteLine("Please enter a Favorite Food : ");
                            FavoriteFood = Console.ReadLine();
                            if (name == "" || homeTown == "" || FavoriteFood == "")
                            {
                                throw new Exception("unvalid input");
                            }
                            else
                            {
                                AddingStudent(name, homeTown, FavoriteFood, Students);
                                foreach (Student s in Students)//print all the students in c# class with new one
                                {
                                    Console.WriteLine("Name: " + s.name + "  HomeTown: " + s.homeTown + " Favorite Food: " + s.favoriteFood);
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            repeat = true;
                        }
                    }

                    else if (userChoice == "" || userChoice != "search")//user input empty string or invalid input
                    {
                        throw new Exception("unvalid input");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                    repeat = true;
                }
             
                }
            }

        public static string SearchStudent(string name, List<Student> list)
        {
            string studentInfo = "";
            foreach(Student s in list)
            { 
                if(s.name == name) 
                {
                    studentInfo += ("Name : "+ s.name + " Hometown : "+s.homeTown +" favorite Food : "+s.favoriteFood);
                    return studentInfo;
                }

            }
            return "-1";
        }

        public static void AddingStudent(string name,string homeTown,String favoriteFood, List<Student> list)
        {
            Student newStudent = new Student() { name = name, homeTown = homeTown, favoriteFood =favoriteFood };
            list.Add(newStudent);
            list.Sort();
        
        }
    }
}
