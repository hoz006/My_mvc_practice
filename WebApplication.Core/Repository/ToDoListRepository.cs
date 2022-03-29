using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Core.Entities;
using WebApplication.Core.Enum;

namespace WebApplication.Core.Repository
{
    public class ToDoListRepository
    {
        private readonly List<ToDoListEntity> ToDoListEntities = new List<ToDoListEntity>()
        { 
            new ToDoListEntity{Id = "1",Title = "标题1",Content = "内容1",Type = ToDoListType.LevelA,CreatedDate = DateTime.Now,CreatorName = "Peter",IsDone = true },
            new ToDoListEntity{Id = "2",Title = "标题2",Content = "内容2",Type = ToDoListType.LevelB,CreatedDate = DateTime.Now,CreatorName = "John",IsDone = false },
            new ToDoListEntity{Id = "3",Title = "标题3",Content = "内容3",Type = ToDoListType.LevelC,CreatedDate = DateTime.Now,CreatorName = "Evan",IsDone = true },
        };

        public List<ToDoListEntity> GetAll()
        {
            return ToDoListEntities;
        }

        public ToDoListEntity GetById(string id)
        {
            return ToDoListEntities.Where(t => t.Id == id).FirstOrDefault();
        }
    }
}
