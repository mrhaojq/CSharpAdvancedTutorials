using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DocumentManager
{
  public  class DocumentManager<TDocument> where TDocument:IDocument
      //给泛型类型添加约束时，最好包含泛型参数名称的一些信息，是程序更具可读性T=》TDocument
    {
        private readonly Queue<TDocument> _documentQueue = new Queue<TDocument>();//Queue:Represents as first-in,first-out collection of objects.

        public void AddDocument(TDocument doc)
        {
            lock (this)//lock 线程问题
            {
                _documentQueue.Enqueue(doc);//Adds an objects to the end of the Queue<TDocument>
            }
        }

        public bool IsDocumentAvailable => _documentQueue.Count > 0;

        public TDocument GetDocument()
        {
            TDocument doc = default(TDocument);//通过Default 关键字，将null赋于引用类型，将0赋予值类型
            lock (this)
            {
                doc = _documentQueue.Dequeue();//Removes and returns the object at the beginning of zhe Queue<TDocument>
            }
            return doc;
        }

        public void DisplayAllDocuments()
        {
            foreach (TDocument doc in _documentQueue)
            {
                //WriteLine(((IDocument)doc).Title);//如果类型T没有实现IDocument接口，就跟产出运行时异常，因此要给DocumentManager<TDocument> 定义一个约束
                //TDocument 必须实现TDocument  where TDocument:IDocument
                WriteLine(doc.Title);
            }
        }
    }
}
