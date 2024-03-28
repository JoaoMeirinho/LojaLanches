﻿using LojaLanches.Context;
using LojaLanches.Models;
using LojaLanches.Repositories.Interfaces;

namespace LojaLanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}