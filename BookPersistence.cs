using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace LibraryManagementSystem
{
    public static class BookPersistence
    {
        private const string BORROWED_BOOKS_FILE = "borrowed_books.json";

        public static Dictionary<string, List<BorrowedBookInfo>> LoadBorrowedBooks()
        {
            if (File.Exists(BORROWED_BOOKS_FILE))
            {
                string jsonString = File.ReadAllText(BORROWED_BOOKS_FILE);
                return JsonSerializer.Deserialize<Dictionary<string, List<BorrowedBookInfo>>>(jsonString);
            }
            return new Dictionary<string, List<BorrowedBookInfo>>();
        }

        public static void SaveBorrowedBooks(Dictionary<string, List<BorrowedBookInfo>> borrowedBooks)
        {
            string jsonString = JsonSerializer.Serialize(borrowedBooks);
            File.WriteAllText(BORROWED_BOOKS_FILE, jsonString);
        }
    }

    public class BorrowedBookInfo
    {
        public string ISBN { get; set; }
        public DateTime DueDate { get; set; }
    }
}
