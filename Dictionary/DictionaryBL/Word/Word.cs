using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dictionary.DictionaryBL.BaseWords;

namespace Dictionary.DictionaryBL.Word
{
    // this class using for all word!!
    public  class Word : BaseWord
    {
        public string Type { get; set; }
        public string Example { get; set; }
        public int? Favorite { get; set; }
    }
}
