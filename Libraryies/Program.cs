using Libraryies.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Libraryies
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"
 __       __            __                                                   
/  |  _  /  |          /  |                                                  
$$ | / \ $$ |  ______  $$ |  _______   ______   _____  ____    ______        
$$ |/$  \$$ | /      \ $$ | /       | /      \ /     \/    \  /      \       
$$ /$$$  $$ |/$$$$$$  |$$ |/$$$$$$$/ /$$$$$$  |$$$$$$ $$$$  |/$$$$$$  |      
$$ $$/$$ $$ |$$    $$ |$$ |$$ |      $$ |  $$ |$$ | $$ | $$ |$$    $$ |      
$$$$/  $$$$ |$$$$$$$$/ $$ |$$ \_____ $$ \__$$ |$$ | $$ | $$ |$$$$$$$$/       
$$$/    $$$ |$$       |$$ |$$       |$$    $$/ $$ | $$ | $$ |$$       |      
$$/      $$/  $$$$$$$/ $$/  $$$$$$$/  $$$$$$/  $$/  $$/  $$/  $$$$$$$/       
                                                                             
                                                                             
                                                                             
");
             TryAgain:
            Console.WriteLine("If You Want Add Book Name Choose 1");
            Console.WriteLine("If You Want Add Book Author Choose 2");
            Console.WriteLine("If you want make Relation with Book and Author Choose 3");
            Console.WriteLine("If You want see all book please choose 4");
            Console.WriteLine("If You want see all author please choose 5");

            int input = int.Parse(Console.ReadLine());


            try
            {
                if (input == 1)
                {

                    Console.Write("Please Enter Book Name:");
                    string InputBookName = Console.ReadLine();
                    Console.Write("Please Enter Genre Name:");
                    string InputGenreName = Console.ReadLine();
                    AddBookEF(InputBookName, InputGenreName);
                    Console.ReadLine();
                    goto TryAgain;
                }



                else if (input == 2)
                {
                    Console.Write("Please Enter Book Name:");
                    string InputAuthorName = Console.ReadLine();
                    Console.Write("Please Enter Surname:");
                    string InputAuthorSurName = Console.ReadLine();
                    AddAuthorEF(InputAuthorName, InputAuthorSurName);
                    Console.ReadLine();
                    goto TryAgain;
                }

                else if (input == 3)
                {
                    Console.WriteLine("Please Enter Book ID");
                    int InputAuthorID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please Enter Author Id");
                    int InputBookID = int.Parse(Console.ReadLine());
                    AddAuthorBookEF(InputBookID, InputAuthorID);
                    Console.ReadLine();
                    goto TryAgain;
                }
                else if (input == 4)
                {
                    AllBook();
                    goto TryAgain;
                }
                else if (input == 5)
                {
                    AllAuthor();
                    goto TryAgain;
                }



            }
            catch (Exception)
            {

                Console.WriteLine("Please input Correct Variant");
                goto TryAgain;
            }
        }

        public static void AddAuthorEF(string InputName, string InputSurname)
        {
            using (AppDBContext db3 = new AppDBContext())
            {
                Author ath1 = new Author { Name = InputName, Surname = InputSurname };
                db3.Author.Add(ath1);
                db3.SaveChanges();

            }

            Console.WriteLine("Author Created");
        }
        public static void AddBookEF(string InputBookName, string InputBookGenre)
        {
            using (AppDBContext db2 = new AppDBContext())
            {
                Book bok1 = new Book { Name = InputBookName };
                db2.Book.Add(bok1);
                db2.SaveChanges();
            }

            Console.WriteLine("Books Created");
        }


        public static void AddAuthorBookEF(int InputBookID, int InputAuthorID)
        {
            using (AppDBContext db = new AppDBContext())
            {
                AuthorBook AB = new AuthorBook { AuthorId = InputAuthorID, BookId = InputBookID };
                db.AuthorBook.Add(AB);
                db.SaveChanges();
            }

            Console.WriteLine("ok");
        }

        public static void AllBook()
        {
            using (var context = new AppDBContext())
            {
                var list = context.AuthorBook.Include(n => n.Book).Include(n => n.author);

                foreach (var item in list)
                {
                    Console.WriteLine(item.Book.Name);
                }


            }

        }

        public static void AllAuthor()
        {
            using (var context = new AppDBContext())
            {
                var list = context.AuthorBook.Include(n => n.Book).Include(n => n.author);

                foreach (var item in list)
                {
                    Console.WriteLine(item.author.Name);
                }


            }

        }

    }

    }




