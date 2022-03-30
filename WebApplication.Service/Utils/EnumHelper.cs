using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Service.Utils
{
    public static class EnumHelper
    {
        #region 获取字段Description(private)
        /// <summary>
        ///  根据Description获取枚举
        /// </summary>
        /// <param name="fieldInfo">FieldInfo</param>
        /// <returns>DescriptionAttribute[] </returns>
        public static T GetEnumName<T>(string description)
        {
            Type _type = typeof(T);
            foreach (FieldInfo field in _type.GetFields())
            {
                DescriptionAttribute[] _curDesc = field.GetDescriptAttr();
                if (_curDesc != null && _curDesc.Length > 0)
                {
                    if (_curDesc[0].Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }
            return default(T);
            //throw new ArgumentException(string.Format("{0} 未能找到对应的枚举.", description), "Description");
        }

        private static DescriptionAttribute[] GetDescriptAttr(this FieldInfo fieldInfo)
        {
            if (fieldInfo != null)
            {
                return (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            }
            return null;
        }
        #endregion

        public static string GetEnumDescription(Enum enumValue)
        {
            string value = enumValue.ToString();
            FieldInfo field = enumValue.GetType().GetField(value);
            object[] objs = field.GetCustomAttributes(typeof(DescriptionAttribute), false);    //获取描述属性
            if (objs == null || objs.Length == 0)    //当描述属性没有时，直接返回名称
                return value;
            DescriptionAttribute descriptionAttribute = (DescriptionAttribute)objs[0];
            return descriptionAttribute.Description;
        }
    }
}
