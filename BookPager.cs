using System;
using System.Collections.Generic;
using System.Linq;


namespace GenericsExample
{
    public class BookPager
    {
        public int CurrentPage { get; set; }
        public int RecordsPerPage { get; set; } = 5;
        public List<Book> AllRecords { get; set; }

        public List<Book> GetCurrentPage()
        {
            var skipAmount = CurrentPage * RecordsPerPage;

            return AllRecords
                .Skip(skipAmount)
                .Take(RecordsPerPage)
                .ToList();
        }

        public List<Book> GetPreviousPage()
        {
            CurrentPage--;
            return GetCurrentPage();
        }

        public List<Book> GetNextPage()
        {
            CurrentPage++;
            return GetCurrentPage();
        }

    }
}