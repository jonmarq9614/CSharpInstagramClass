using System;
using myInstagramClass.Models;
using myInstagramClass.DTOS;

namespace myInstagramClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Users userName = new Users("Jonathan", "Marquez");
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

        }
    }

}
