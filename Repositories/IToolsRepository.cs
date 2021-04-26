using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using desafio01.Models;

namespace desafio01.Repositories
{
    public interface IToolsRepository
    {
        Task<ToolsForReturn> Create(ToolForCreation tool);
        void Update(Tool tool);
        Task Delete(Guid Id);
        Tool GetById(Guid toolId);

        Task<IEnumerable<Tool>> GetTools(string tag);
    }
}