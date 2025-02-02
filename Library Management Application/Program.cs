using Library_Management_Application.Exceptions;
using Library_Management_Application.Models;
using Library_Management_Application.Services.Implementations;
using Library_Management_Application.Services.Interfaces;

namespace Library_Management_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plase choose operation");
            Console.WriteLine();
            Console.WriteLine("2-Book actions");

            int bookInput;
            do
            {
                Input:
                IBookServices bookServices = new BookServices();
                bookInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1-All book list");
                Console.WriteLine("2-Create book");
                Console.WriteLine("3-Edit book");
                Console.WriteLine("4-Remove book");
                Console.WriteLine("0-Return main operations");
                try
                {
                    if (bookInput < 0) throw new InvalidException("Input can not be less than 0");
                    if (string.IsNullOrWhiteSpace(bookInput.ToString())) throw new Exception("Input can not null or empty");
                }
                catch(InvalidException ex)
                {
                    Console.WriteLine($"Eror:{ex.Message}");
                    goto Input;
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Eror:{ex.Message}");
                    goto Input;
                }
                
                switch (bookInput)
                {

                    case 1:
                       var list = bookServices.GetAll();
                        try
                        {
                            if (list.Count <= 0) throw new InvalidException("List is empty");
                        }
                        catch(InvalidException ex)
                        {
                            Console.WriteLine($"Eror:{ex.Message}");

                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine($"Eror:{ex.Message}");
                        }
                        foreach(var item in list)
                        {
                            Console.WriteLine($"Id:{item.Id}, Title:{item.Title}, Descreption:{item.Desc}, Published Year:{item.PublishedYear}, Authors:{item.AuthorNames}");
                        }
                        break;
                    case 2:
                        IBookServices bookService = new BookServices();
                        Console.WriteLine("Please enter book title");
                        string bookTitle = Console.ReadLine();
                        Console.WriteLine("Please enter book descreption");
                        string bookDecs = Console.ReadLine();
                        Console.WriteLine("Please enter book published year");
                        int bookPublishedYear = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter book authors");
                        //List<>
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 0:
                        break;
                }
            }
            while (bookInput != 0);


            
            }
    }
}