
using System;

namespace WooSerialization.DataTable
{
    /// <summary>
    /// 数据表忽略的成员
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class DataIgnoreAttribute: Attribute { }
}
