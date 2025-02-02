﻿using Library_Management_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_Application.DTOs.BookDtos
{
    public class BookCreateDto
    {
        public int Id { get; set; }    
        public string Title { get; set; }
        public string Desc { get; set; }
        public int PublishedYear { get; set; }
        public List<int> AuthorIds { get; set; }
        
        
    }
}
