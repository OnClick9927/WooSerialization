
using System;

namespace WooSerialization.DataTable
{
    /// <summary>
    /// 设置数据表标题
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class DataColumnNameAttribute : Attribute
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="name">名称</param>
        public DataColumnNameAttribute(string name) { this.name = name; }
        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; private set; }
    }
}
