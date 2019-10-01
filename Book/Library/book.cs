using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Library
{
    public class Book
    {
        private string _title; // minimum 2 tegn
        private string _author;
        private int _pages;
        private string _isbn;


        public Book(string title, string author, int pages, string isbn)
        {
            _title = title;
            _author = author;
            _pages = pages;
            _isbn = isbn;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public int Pages
        {
            get => _pages;
            set => _pages = value;
        }

        public string Isbn
        {
            get => _isbn;
            set => _isbn = value;
        }

        public override string ToString()
        {
            return $"{nameof(Title)}: {Title}, {nameof(Author)}: {Author}, {nameof(Pages)}: {Pages}, {nameof(Isbn)}: {Isbn}";
        }
        public Book()
        {

        }
    }
}
