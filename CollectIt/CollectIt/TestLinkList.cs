using System;
using System.Collections.Generic;

namespace CollectIt
{
    public class TestLinkList
    {
        public void Can_Add_After()
        {
            var list = new LinkedList<string>();
            list.AddFirst("Hello");
            list.AddLast("World");
            list.AddAfter(list.First, "there");

        }
    }
}
