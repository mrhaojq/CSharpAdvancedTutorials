using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharpAttribute
{
    //一个自定义特性 BugFix 
    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Constructor |
        AttributeTargets.Field |
        AttributeTargets.Method |
        AttributeTargets.Property,
        AllowMultiple = true)]
    public class DeBugInfo : System.Attribute
    {
        private int _bugNo;
        private string _developer;
        private string _lastReview;
        private string _message;

        public DeBugInfo(int bg, string dev, string d)
        {
            _bugNo = bg;
            _developer = dev;
            _lastReview = d;
        }

        public int BugNo
        {
            get { return _bugNo; }
        }

        public string Developer
        {
            get { return _developer; }
        }

        public string LastReview
        {
            get { return _lastReview; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
    }
}
