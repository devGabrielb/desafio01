using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio01.Data;
using desafio01.Models;
using Microsoft.EntityFrameworkCore;

namespace desafio01.Repositories
{
    public class ToolsRepository : IToolsRepository
    {
        private readonly DataContext _dataConext;
        public ToolsRepository(DataContext dataConext)
        {
            _dataConext = dataConext;
        }
        public async Task<ToolsForReturn> Create(ToolForCreation tool)
        {
            var newTagList = new List<Tag>();

            foreach (var item in tool.Tags)
            {
                newTagList.Add(new Tag() { TagName = item });
            }
            var newTool = new Tool() { Title = tool.Title, Description = tool.Description, Link = tool.Link, Tags = newTagList };
            _dataConext.Tools.Add(newTool);
            await _dataConext.SaveChangesAsync();

            var toolForReturn = new ToolsForReturn() { Id = newTool.Id, Link = newTool.Link, Title = newTool.Title, Description = newTool.Description, Tags = tool.Tags };
            return toolForReturn;
        }

        public async Task Delete(Guid toolsId)
        {
            var tool = await _dataConext.Tools.Include(x => x.Tags).FirstOrDefaultAsync(x => x.Id == toolsId);

            _dataConext.Tools.Remove(tool);
            _dataConext.SaveChanges();

        }

        public Tool GetById(Guid ToolId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Tool>> GetTools(string tag)
        {
            var collection = _dataConext.Tools as IQueryable<Tool>;

            if (!String.IsNullOrWhiteSpace(tag))
            {
                var newTag = tag.Trim();

                collection = collection.Where(x => x.Tags.Any(x => x.TagName == newTag)).Include(x => x.Tags);

            }

            return await collection.Include(x => x.Tags).AsNoTracking().ToListAsync();
        }

        public void Update(Tool tool)
        {
            throw new NotImplementedException();
        }
    }
}