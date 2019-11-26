using System;
using System.Collections.Generic;
using System.Linq;


namespace GenericsExample
{
    public class Pager<T>
    {
        private List<T> _allRecords;

        public int CurrentPage { get; set; }
        public int RecordsPerPage { get; set; } = 5;

        public Pager(List<T> list)
        {
            _allRecords = list;
        }

        public List<T> GetCurrentPage()
        {
            var skipAmount = CurrentPage * RecordsPerPage;

            return _allRecords
                .Skip(skipAmount)
                .Take(RecordsPerPage)
                .ToList();
        }

        public List<T> GetPreviousPage()
        {
            CurrentPage--;
            return GetCurrentPage();
        }

        public List<T> GetNextPage()
        {
            CurrentPage++;
            return GetCurrentPage();
        }

    }
}