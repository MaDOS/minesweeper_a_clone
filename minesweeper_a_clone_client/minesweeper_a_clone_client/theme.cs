using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;
using System.Text;
using System.Windows;

namespace minesweeper_a_clone_client
{
    public class Theme
    {
        public string path;
        public string name;
        public ResourceDictionary xamlRes;

        public Theme(string path, string name, ResourceDictionary xamlRes)
        {
            this.path = path;
            this.name = name;
            this.xamlRes = xamlRes;
        }
    }
}
