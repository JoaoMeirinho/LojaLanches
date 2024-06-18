using LojaLanches.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LojaLanches.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categiaRepository;
        public CategoriaMenu(ICategoriaRepository categiaRepository)
        {
            _categiaRepository = categiaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categiaRepository.Categorias.OrderBy(c => c.CategoriaNome);
            return View(categorias);
        }
    }
}
