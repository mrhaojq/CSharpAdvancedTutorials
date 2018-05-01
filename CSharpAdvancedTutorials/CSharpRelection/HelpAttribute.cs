using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;//特征的

namespace CSharpRelection
{
    //自定义特性
    [AttributeUsage(AttributeTargets.All)]
  public  class HelpAttribute:System.Attribute
    {
        public readonly string Url;
        private string _topic;
        public string Topic
        {
            get { return _topic; }
            set { _topic = value; }
        }

        public HelpAttribute(string url)
        {
            Url = url;
        }
    }
}
