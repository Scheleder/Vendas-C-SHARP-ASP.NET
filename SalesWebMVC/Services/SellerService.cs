using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Services.Exceptions;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            var result = from obj in _context.Seller select obj;
            
            // retorna vendedores, incluindo seus departamentos e ordenando pelo nome
            return await result
                .Include(x => x.Department)
                .OrderBy(x => x.Name)
                .ToListAsync();

            //return await _context.Seller.ToListAsync();

        }

        public async Task InsertAsync(Seller obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            // retorna vendedor de existir
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                // busca o vendedor
                var obj = await _context.Seller.FindAsync(id);
                // exclui o vendedor
                _context.Seller.Remove(obj);
                // salva as alterações
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Can't delete seller because he/she has sales. Msg:"+e);
            }
        }

        public async Task UpdateAsync(Seller obj)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                // se não existir, msg de erro
                throw new NotFoundException("Id not found");
            }
            try
            {
                // atualiza dados do vendedor e salva
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
