﻿using ConsoleApp.Models;

namespace ConsoleApp.Repositories
{
    public class AuthorRepository
    {
        //не вижу смысла сейчас имплементить абсолютно все логичные в этом контексте методы, чтоб не затягивать с заданием

        private readonly AppContext _context;
        public AuthorRepository(AppContext context) 
        {
            _context = context;
        }
        public Author GetAuthorByName(string authorName)
        {
            return _context.Authors.FirstOrDefault(a => a.Name == authorName);
        }
    }
}
