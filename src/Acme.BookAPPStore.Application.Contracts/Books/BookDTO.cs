﻿using System;

namespace Acme.BookAPPStore.Books
{
    public class BookDTO
    {
        public string Name { get; set; } = string.Empty;
        public BookType Type { get; set; }
        public DateTime PublishDate { get; set; }
        public float Price { get; set; }
    }
}
