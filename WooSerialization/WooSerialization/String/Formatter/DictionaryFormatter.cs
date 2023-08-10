using System.Collections.Generic;
using System.Text;

namespace WooSerialization
{
    public class DictionaryFormatter<K,V> : StringFormatter<Dictionary<K,V>>
    {
        const string keyChar = "k";
        const string valueChar = "v";
        Dictionary<K, V> dic = new Dictionary<K, V>();
        StringFormatter<K> k = StringConvert.GetFormatter(typeof(K)) as StringFormatter<K>;
        StringFormatter<V> v = StringConvert.GetFormatter(typeof(V)) as StringFormatter<V>;
        public override void ConvertToString(Dictionary<K, V> t, StringBuilder builder)
        {
            if (t == null || t.Count == 0) return;
            builder.Append(StringConvert.leftBound);
            int count = 0;
            foreach (var item in t)
            {
                var _key = item.Key;
                var _value = item.Value;
                count++;
                builder.Append("\"");
                k.ConvertToString(_key, builder);
                builder.Append("\"");
          
                builder.Append(StringConvert.colon);
                v.ConvertToString(_value, builder);
       
                if (count != t.Count)
                {
                    builder.Append(StringConvert.dot.ToString());
                }
            }
            builder.Append(StringConvert.rightBound);

        }
        private void Read(string self, Dictionary<K, V> result)
        {
            K lastKey = default(K);
            ObjectFormatter<K>.ReadObject(self, (fieldName, inner) =>
            {
                if (fieldName == keyChar)
                {
                    k.TryConvert(inner, out lastKey);
                }
                else if (fieldName == valueChar)
                {
                    V value;
                    if (v.TryConvert(inner, out value))
                    {
                        result.Add(lastKey, value);
                    }
                    else
                    {
                        result.Add(lastKey, default(V));
                    }
                }
            });
        }

        public override bool TryConvert(string self, out Dictionary<K, V> result)
        {
            dic.Clear();
            bool bo = ListFormatter<K>.ReadArray(self, (inner) =>
            {
                if (inner.EndsWith(StringConvert.dot.ToString()))
                {
                    inner = inner.Remove(inner.Length - 1, 1);
                }
                Read(inner, dic);
            });
            if (bo)
            {
                result = new Dictionary<K, V>(dic);
            }
            else
            {
                result = MakeDefault();
            }
            return bo;
        }
    }
}
