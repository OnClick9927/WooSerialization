﻿using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WooSerialization
{
    public class QueueFormatter<T> : StringFormatter<Queue<T>>
    {
        public override void ConvertToString(Queue<T> t, StringBuilder builder)
        {
            ListFormatter<T> c = StringConvert.GetFormatter(typeof(List<T>)) as ListFormatter<T>;
            c.ConvertToString(t.ToList(), builder);
        }

        public override bool TryConvert(string self, out Queue<T> result)
        {
            ListFormatter<T> c = StringConvert.GetFormatter(typeof(List<T>)) as ListFormatter<T>;
            List<T> list;
            if (!c.TryConvert(self, out list))
            {
                result = MakeDefault();
                return false;
            }
            else
            {
                result = new Queue<T>(list);
                return true;
            }
        }
    }
}
