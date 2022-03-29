using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Core.Enum;
using Newtonsoft.Json;

namespace WebApplication.Core.Entities
{
    public class ToDoListEntity
    {
        /// <summary>
        /// 主键id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 是否完成
        /// </summary>
        [JsonProperty("isDone")]
        public bool IsDone { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("type")]
        public ToDoListType Type { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        [JsonProperty("createdDate")]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("creatorName")]
        public string CreatorName { get; set; }
    }
}
