using System;
using System.Collections.Generic;
using System.Text;

namespace AObaidiP5.Shared
{
    public class SnowBoard
    {
        public int OrderId { get; set; }
        public string ImageFileName { get; set; }
        public bool IncludeBindings { get; set; }
        public bool IsRegularFoot { get; set; }
        public double Lenght { get; set; }
        public double Width { get; set; }
        public string BindingOption { get; set; }
    }
}
