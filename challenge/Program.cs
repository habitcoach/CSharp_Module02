using System;

class Program
{
    static string[] titles = new string[100];
    static string[] authors = new string[100];
    static string[] isbns = new string[100];
    static string[] genres = new string[100];
    static int[] publicationYears = new int[100];
    static int bookCount = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. Remove a Book");
            Console.WriteLine("3. Search by Title");
            Console.WriteLine("4. Search by Author");
            Console.WriteLine("5. Search by Title and Author");
            Console.WriteLine("6. Display All Books");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddBook();
                    break;
                case 2:
                    RemoveBook();
                    break;
                case 3:
                    string title = Console.ReadLine();
                    SearchByTitle(title);
                    break;
                case 4:
                    string author = Console.ReadLine();
                    SearchByAuthor(author);
                    break;
                case 5:
                    string titleS = Console.ReadLine();
                    string authorS = Console.ReadLine();
                    SearchByTitleAndAuthor(titleS,authorS);
                    break;
                case 6:
                    DisplayAllBooks();
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddBook()
    {
        Console.Write("Enter title: ");
        string title = Console.ReadLine();
        Console.Write("Enter author: ");
        string author = Console.ReadLine();
        Console.Write("Enter ISBN: ");
        string isbn = Console.ReadLine();
        Console.Write("Enter genre: ");
        string genre = Console.ReadLine();
        Console.Write("Enter publication year: ");
        int publicationYear = int.Parse(Console.ReadLine());

        titles[bookCount] = title;
        authors[bookCount] = author;
        isbns[bookCount] = isbn;
        genres[bookCount] = genre;
        publicationYears[bookCount] = publicationYear;

        Console.WriteLine("Book added successfully.");
        bookCount++;
    }

    static void RemoveBook()
    {
        Console.Write("Enter ISBN of the book to remove: ");
        string isbn = Console.ReadLine();
        int index = Array.IndexOf(isbns, isbn);
        if (index != -1)
        {
            for (int i = index; i < bookCount - 1; i++)
            {
                titles[i] = titles[i + 1];
                authors[i] = authors[i + 1];
                isbns[i] = isbns[i + 1];
                genres[i] = genres[i + 1];
                publicationYears[i] = publicationYears[i + 1];
            }
            bookCount--;
            Console.WriteLine("Book removed successfully.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    static void SearchByTitle(string title)
    {
        bool found = false;
        for (int i = 0; i < bookCount; i++)
        {
            if (titles[i] == title)
            {
                Console.WriteLine($"Title: {titles[i]}, Author: {authors[i]}, ISBN: {isbns[i]}, Genre: {genres[i]}, Publication Year: {publicationYears[i]}");
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("No books found with the given title.");
        }
    }

    static void SearchByAuthor(string author)
    {
        bool found = false;
        for (int i = 0; i < bookCount; i++)
        {
            if (authors[i] == author)
            {
                Console.WriteLine($"Title: {titles[i]}, Author: {authors[i]}, ISBN: {isbns[i]}, Genre: {genres[i]}, Publication Year: {publicationYears[i]}");
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("No books found by the given author.");
        }
    }

    static void SearchByTitleAndAuthor(string title, string author)
    {
        bool found = false;
        for (int i = 0; i < bookCount; i++)
        {
            if (titles[i] == title && authors[i] == author)
            {
                Console.WriteLine($"Title: {titles[i]}, Author: {authors[i]}, ISBN: {isbns[i]}, Genre: {genres[i]}, Publication Year: {publicationYears[i]}");
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("No books found with the given title and author.");
        }
    }

    static void DisplayAllBooks()
    {
        if (bookCount == 0)
        {
            Console.WriteLine("No books in the library.");
        }
        else
        {
            Console.WriteLine("All Books:");
            for (int i = 0; i < bookCount; i++)
            {
                Console.WriteLine($"Title: {titles[i]}, Author: {authors[i]}, ISBN: {isbns[i]}, Genre: {genres[i]}, Publication Year: {publicationYears[i]}");
            }
        }
    }
}
