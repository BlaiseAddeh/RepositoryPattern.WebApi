using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
    }
}
