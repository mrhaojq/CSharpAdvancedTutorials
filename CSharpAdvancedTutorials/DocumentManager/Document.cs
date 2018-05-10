using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentManager
{
    public class Document : IDocument
    {
        //通过接口 约定必须含有下面两个属性
        public string Title { get; set; }
        public string Content { get; set; }

        //通过构成函数初始化数据
        public Document(string title, string content)
        {
            this.Title = title;
            this.Content = content;
        }
    }
}
