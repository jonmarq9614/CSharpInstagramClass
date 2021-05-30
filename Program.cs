using System;
using myInstagramClass.Models;
using myInstagramClass.DTOS;
using System.Collections.Generic;

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

            bool myAnswer = true;

            int counter = 1;

            while (myAnswer)
            {
                Console.WriteLine(counter);
                counter++;

                if (counter > 20)
                {
                    myAnswer = false;


                }
            }


            int[] myArray = {1,2,3,4,5,6,7,8,9,10};

            foreach (var value in myArray)
            {
                Console.WriteLine(value);
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

            foreach(var item in myList)
            {
                Console.WriteLine(item);
            }*/

            string answer = "";

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
            }











        }
    }

}
