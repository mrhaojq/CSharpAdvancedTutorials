using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentManager
{
   public interface IDocument
    {
        string Title { get; set; }
        string Content { get; set; }
    }
}
