﻿namespace WooSerialization
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释

    public abstract class StringConverter
    {
        public abstract string ConvertToString(object t);
        public abstract bool TryConvertObject(string str, out object result);
    }
    public abstract class StringConverter<T> : StringConverter
    {
        public virtual string ConvertToString(T t)
        {
            return t.ToString();
        }
        public abstract bool TryConvert(string self, out T result);

        public override bool TryConvertObject(string str, out object result)
        {
            T t;
            if (TryConvert(str, out t))
            {
                result = t;
                return true;
            }
            else
            {
                result = default(T);
                return false;
            }
        }
        public override string ConvertToString(object t)
        {
            return ConvertToString((T)t);
        }

    }
}
