using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yackeenTask.ViewModels
{
    public class viewArticls
    {
        public int articlid { set; get; }
        public string title { set; get; }
        public string article { set; get; }
        public DateTime articleDate { set; get; }

        public List<viewCategory> categ{ set; get; }
}
}