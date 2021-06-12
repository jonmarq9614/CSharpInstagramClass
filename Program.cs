using System;
using myInstagramClass.Models;
using myInstagramClass.DTOS;
using System.Collections.Generic;
using System.Linq;

namespace myInstagramClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Users userName = new Users("Jonathan", "Marquez");
            Roles role = new Roles("Actor");
            Images image = new Images("Image 1", "Image 2");
            Posts post = new Posts("at Los Angeles with my family", "About to go swim");
            Comments comment = new Comments("Have a safe trip");

            string nameString = "User {0} {1}";
            string roleString = "is an {0}";
            string imageString = "{0}, {1}";
            string postString = "{0}, {1}";
            string commentString = "{0}";

            UsersDTO newDTOUser = new UsersDTO();
            newDTOUser.first = "Jon";
            newDTOUser.last = "Marq";

            string newUserDTO = "{0} {1}";

            Console.WriteLine(String.Format(newUserDTO, newDTOUser.first, newDTOUser.last));

            Console.WriteLine(String.Format(nameString, userName.first, userName.last));
            Console.WriteLine(String.Format(roleString, role.role1));
            Console.WriteLine(String.Format(imageString, image.image1, image.image2));
            Console.WriteLine(String.Format(postString, post.post1, post.post2));
            Console.WriteLine(String.Format(commentString, comment.comment1));

            DateTime myDate1 = DateTime.Now;
            DateTime myDate2 = new DateTime(1996, 07, 11);

            if (myDate1 > myDate2)
            {
                Console.WriteLine(myDate1 + " is greater than " + myDate2);
            }
            else
            {
                Console.WriteLine(myDate1 + " is less than " + myDate2);
            }

            int result = 0;

            for(int x = 1; x < 21; x++)

            {
                result = result + x;
            }

            Console.WriteLine(result);


            int[] myArray = {1,2,3,4,5,6,7,8,9,10};

            Console.WriteLine("The values on the array are:");
            foreach (var value in myArray)
            {
                Console.Write(value + ", ");
            }


            List<string> myList = new List<string>();

            myList.Add("string 1");
            myList.Add("string 2");
            myList.Add("string 3");
            myList.Add("string 4");
            myList.Add("string 5");
            myList.Add("string 6");
            myList.Add("string 7");
            myList.Add("string 8");
            myList.Add("string 9");
            myList.Add("string 10");

            Console.WriteLine("");
            Console.WriteLine("The values on the list are:");
            foreach(var item in myList)
            {
                Console.Write(item + ", ");
            }*/

            /* string answer = "";

             while (answer != "5")
             {
                 Console.WriteLine("1. Create a User");
                 Console.WriteLine("2. Create a Comment");
                 Console.WriteLine("3. Print the List of Users");
                 Console.WriteLine("4. Print the List of Comments");
                 Console.WriteLine("5. Exit");

                 Console.WriteLine("");
                 Console.WriteLine("Select a value");

                 answer = Console.ReadLine();

                 switch (answer)
                 {
                     case "1":
                         UsersDTO user = new UsersDTO();
                         user.first = "Jonathan";
                         user.last = "Marquez";
                         user.email = "email@gmail.com";
                         user.user = "Jonmarq";
                         user.password = "myPassword";

                         break;
                     case "2":
                         Comments comment = new Comments();
                         comment.comment1 = "Life is like a box of chocolates";
                         break;
                     case "3":
                     foreach(var element in UsersDTO)
                         {
                             Console.WriteLine(element);
                         }
                         break;
                     case "4":
                         foreach (var asset in Comments)
                         {
                             Console.WriteLine(asset);
                         }
                         break;
                 }

                 Console.WriteLine("you selected: " + answer);
            }*/

            /*try
            {
                List<Users> userList = new List<Users>();

                Users firstUser = new Users();
                firstUser.first = "Jonathan";
                firstUser.last = "Marquez";
                firstUser.email = "student@southwestuniversity.edu";
                firstUser.user = "superUser";
                firstUser.password = "myPassword";

                userList.Add(firstUser);
                Users secondUser = new Users();
                secondUser.first = "Jon";
                secondUser.last = "Marq";
                secondUser.email = "student2@southwestuniversity.edu";
                secondUser.user = "smartUser";
                secondUser.password = "myPassword2";

                userList.Add(secondUser);

                Users thirdUser = new Users();
                thirdUser.first = "Celeste";
                thirdUser.last = "Mar";
                thirdUser.email = "student3@southwestuniversity.edu";
                thirdUser.user = "amazingUser";
                thirdUser.password = "myPassword3";

                userList.Add(thirdUser);

                Users fourthUser = new Users();
                fourthUser.first = "Alexis";
                fourthUser.last = "Hernandez";
                fourthUser.email = "student4@southwestuniversity.edu";
                fourthUser.user = "creativeUser";
                fourthUser.password = "myPassword4";

                userList.Add(fourthUser);

                Users fifthUser = new Users();
                fifthUser.first = "David";
                fifthUser.last = "Armani";
                fifthUser.email = "student5@southwestuniversity.edu";
                fifthUser.user = "funnyUser";
                fifthUser.password = "myPassword5";

                userList.Add(fifthUser);

                Users sixthUser = new Users();
                sixthUser.first = "Amery";
                sixthUser.last = "Eve";
                sixthUser.email = "student6@southwestuniversity.edu";
                sixthUser.user = "comedianUser";
                sixthUser.password = "myPassword6";

                userList.Add(sixthUser);

                Users seventhUser = new Users();
                seventhUser.first = "Irma";
                seventhUser.last = "Cordero";
                seventhUser.email = "student7@southwestuniversity.edu";
                seventhUser.user = "momUser";
                seventhUser.password = "myPassword7";

                userList.Add(seventhUser);

                userList.Add(firstUser);
                Users eighthUser = new Users();
                eighthUser.first = "Gera";
                eighthUser.last = "Cordero";
                eighthUser.email = "student8@southwestuniversity.edu";
                eighthUser.user = "familyUser";
                eighthUser.password = "myPassword8";

                userList.Add(eighthUser);

                userList.Add(firstUser);
                Users ninethUser = new Users();
                ninethUser.first = "Issac";
                ninethUser.last = "Guzman";
                ninethUser.email = "student9@southwestuniversity.edu";
                ninethUser.user = "cousinUser";
                ninethUser.password = "myPassword9";

                userList.Add(ninethUser);

                Users tenthUser = new Users();
                tenthUser.first = "Cruz";
                tenthUser.last = "Marquez";
                tenthUser.email = "student10@southwestuniversity.edu";
                tenthUser.user = "dadUser";
                tenthUser.password = "myPassword10";

                userList.Add(ninethUser);

                List<Users> result = userList.OrderBy(Users => Users.user == "dogUser").ToList();

                if(result == userList.OrderBy(Users => Users.user == "dogUser").ToList())
                {
                    throw new MyUserException("i didnt find that user");
                }
            }
            catch(MyUserException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Program has ended");
            }*/



            /*MyGenericClass myClass = new MyGenericClass();
            myClass.MyProperty = "Generic string";
            myClass.MyProperty2 = "Generic string 2";
            myClass.MyProperty3 = 42;

            Console.WriteLine(myClass.MyProperty);
            Console.WriteLine(myClass.MyProperty2);
            Console.WriteLine(myClass.MyProperty3);

            NewGenericClass<int> myNewClass = new NewGenericClass<int>();
            myNewClass.MyNormalProperty = "My new generic string";
            myNewClass.MyGenericProperty = 1996;

            Console.WriteLine(myNewClass.MyNormalProperty);
            Console.WriteLine(myNewClass.MyGenericProperty);*/


            RegularClass newRegularClass = new RegularClass();
            newRegularClass.ConsolePrint<string, int>("String 1", "String 2", 22);

        }



        
    }
}


public class RegularClass
{
    public void ConsolePrint<T, J>(string parameter1, T parameter2, J parameter3)
    {
        Console.WriteLine("My parameter values are:");
        Console.WriteLine(parameter1);
        Console.WriteLine(parameter2);
        Console.WriteLine(parameter3);
    }
}

/*public class MyGenericClass
{
    public string MyProperty { get; set; }
    public string MyProperty2 { get; set; }
    public int MyProperty3 { get; set; }
}

public class NewGenericClass<Key>
{
    public string MyNormalProperty { get; set; }
    public Key MyGenericProperty { get; set; }
}*/


/*public class MyUserException : Exception
{
    public MyUserException(string errorMessage) : base(errorMessage)
    {
        
    }
}*/