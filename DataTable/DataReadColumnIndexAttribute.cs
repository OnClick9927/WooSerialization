
using System;

namespace WooSerialization.DataTable
{
    /// <summary>
    /// 数据列
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class DataReadColumnIndexAttribute:Attribute
    {
        /// <summary>
        /// 所在列
        /// </summary>
        public int index { get; }
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="index"></param>
        public DataReadColumnIndexAttribute(int index)
        {
            this.index = index;
        }
    }
}
