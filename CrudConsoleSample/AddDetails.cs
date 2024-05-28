using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudConsoleSample1234;
using CrudConsoleSample;
using CrudConsoleSample1234;

namespace CrudConsoleSample12
{
     public class AddDetails
    {

        public void MethodMenu()
        {
            var ChooseeNumber = 0;
            do
            {
                Console.WriteLine("Enter The Number Show The Details");
                Console.WriteLine("1.InsertValues:");
                Console.WriteLine("2.ChangePassword:");
                Console.WriteLine("3.DeleteDetails:");
                Console.WriteLine("4.Show All Details:");
                
                Console.WriteLine("5.Exist:");



                Console.WriteLine("Enter The Number:");
                ChooseeNumber = Convert.ToInt32(Console.ReadLine());
                switch (ChooseeNumber)
                {
                    case 1:
                        
                        
                        SignUpDetails();
                        break;
                    case 2:
                        update();
                        break;
                    case 3:
                        DeleteT();
                        break;
                    case 4:
                        Select();
                        break;
                    case 5:
                        
                        break;


                }

            } while (ChooseeNumber != 5);
        }
        BookConnection obj = new BookConnection();
        BookShop Regis = new BookShop();
        //BookShop Regis = new();
        //Regis.Username = username;
        public void SignUpDetails()
        {
            try
            {


                Console.WriteLine("Enter The BookName:");
                var BookName = Console.ReadLine();
                Console.WriteLine("Enter The Authour:");
                var Authour = Console.ReadLine();
                Console.WriteLine("Enter The ToatalNoPages:");
                var ToatalNoPages = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The PublishedBy:");
                var PublishedBy = Console.ReadLine();
                Console.WriteLine("Enter The ContactNo:");
                var ContactNo = Convert.ToInt64(Console.ReadLine());
                //RegistrationForm Regis = new RegistrationForm();
                Regis.BookName = BookName;
                Regis.Authour = Authour;
                Regis.ToatalNoPages = ToatalNoPages;
                Regis.PublishedBy = PublishedBy;
                Regis.ContactNo = ContactNo;

                //RedistrationsConnection obj = new RedistrationsConnection();

                obj.SignUp1(Regis);

            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void update()
        {
        //    //var username1 = 0;

            try
            {



                Console.WriteLine("Enter The BookName");
                var BookName = Console.ReadLine();

                BookConnection obj = new BookConnection();
                var results = obj.valid(BookName);
               if (results.Any())
                {

                    Console.WriteLine("Enter Your ToatalNoPages:");
                    var ToatalNoPages = Console.ReadLine();
        //            // RedistrationsConnection obj = new RedistrationsConnection();
                    obj.SignUpUpdate(BookName, ToatalNoPages);
                   Console.WriteLine("Update Successfull");

                }
                else
                {

                    Console.WriteLine(" No UserFound So Update failure");
                }



            }
            catch (Exception ex)
            {
                throw;
           }
        }
        public void DeleteT()

        {
            try
            {
                Console.WriteLine("Delete The BookName");
                var BookName = Console.ReadLine();

                BookConnection obj = new BookConnection();
                var results = obj.valid(BookName);
                if (results.Any())
                {


                    Console.WriteLine("Delete Successfull");

                }
                else
                {

                    Console.WriteLine(" No UserFound So Delete failure");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public void Select()
        {
            try
          {


        //        //RedistrationsConnection obj = new RedistrationsConnection();
               var result = obj.Select();
              if (result == null || result.Count() == 0)
               {
                   Console.WriteLine("No Records Found");
                   return;
               }

                Console.WriteLine($" |      {"BookName"}        |           {"Authour"}      |          {"ToatalNoPages"}       |           {"PublishedBy"}         |       { "ContactNo"} ");


                foreach (var all in result)
               {


                    Console.WriteLine($" | {all.BookName}      //    {all.Authour}        //      {all.ToatalNoPages}         //     {all.PublishedBy}         //    {all.ContactNo}");
                }

            }
            catch (Exception ex)
            {
                throw;
           }



        }

    }
}
