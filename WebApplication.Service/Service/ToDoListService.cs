using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Core.Entities;
using WebApplication.Core.Repository;

namespace WebApplication.Service.Service
{
    public class ToDoListService
    {
        private readonly ToDoListRepository ToDoListRepository;

        public ToDoListService()
        {
            ToDoListRepository = new ToDoListRepository();
        }

        /// <summary>
        /// 获取全部待办
        /// </summary>
        /// <returns></returns>
        public List<ToDoListEntity> GetAll()
        {
            return ToDoListRepository.GetAll();
        }

        /// <summary>
        /// 根据id获取一条待办
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ToDoListEntity GetById(string id)
        {
            return ToDoListRepository.GetById(id);
        }
    }
}
