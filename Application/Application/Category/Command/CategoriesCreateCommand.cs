using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Application.Category.Command;

public class CategoriesCreateCommand : IGenericRepositoryAsync<Domain.Entities.Category>
{
    public Task<Domain.Entities.Category> AddAsync(Domain.Entities.Category entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Domain.Entities.Category entity)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<Domain.Entities.Category>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Domain.Entities.Category> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<Domain.Entities.Category>> GetPagedReponseAsync(int pageNumber, int pageSize)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Domain.Entities.Category entity)
    {
        throw new NotImplementedException();
    }
}
