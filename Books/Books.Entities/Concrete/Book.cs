using Entities.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Entities.Concrete
{
    public class Book : IEntity
    {
        public int id { get; set; }
        public string title { get; set; }
        public string rating { get; set; }
      
    }
}
