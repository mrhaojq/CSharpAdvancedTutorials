using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CSharpAttribute;
using static System.Console;

namespace CSharpRelection
{
    class ExecuteRectangle
    {
        public void ExeRectangle()
        {
            Rectangle r = new Rectangle(4.5, 7.5);
            r.Display();

            Type type = typeof(Rectangle);
            //遍历Rectangle类的特性
            foreach (var attributes in type.GetCustomAttributes(false))
            {
                DeBugInfo dbi = (DeBugInfo)attributes;
                if (dbi != null)
                {
                    WriteLine($"Bug no:{dbi.BugNo}");
                    WriteLine($"Developer:{dbi.Developer}");
                    WriteLine($"Last Review:{dbi.LastReview}");
                    WriteLine($"Remarks:{dbi.Message}");
                }
            }

            //遍历方法特性
            foreach (MethodInfo m in type.GetMethods())
            {
                foreach (Attribute a in m.GetCustomAttributes(true))
                {

                    if (a is DeBugInfo)
                    {
                        DeBugInfo dbi = (DeBugInfo)a;
                        if (dbi != null)
                        {
                            WriteLine($"Bug no:{dbi.BugNo}");
                            WriteLine($"Developer:{dbi.Developer}");
                            WriteLine($"Last Review:{dbi.LastReview}");
                            WriteLine($"Remarks:{dbi.Message}");
                        }
                    }
                }
            }
        }
    }
}
