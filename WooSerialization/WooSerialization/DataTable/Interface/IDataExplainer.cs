
using System.Collections.Generic;
using System.Reflection;

namespace WooSerialization.DataTable
{
    /// <summary>
    /// string 解释器
    /// </summary>
    public interface IDataExplainer
    {
        /// <summary>
        /// 根据格子反序列化一个实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cols"></param>
        /// <param name="membersDic">需要反序列化的成员</param>
        /// <returns></returns>
        T CreatInstance<T>(List<DataColumn> cols, Dictionary<MemberInfo, string> membersDic);
        /// <summary>
        /// 根据 具体类型 获取单个数据格子数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="membersDic">需要序列化的成员</param>
        /// <returns></returns>
        List<DataColumn> GetColumns<T>(T t, Dictionary<MemberInfo, string> membersDic);
    }
}
