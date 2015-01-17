using System.Collections.Generic;
using Orchestra.DataLayer;

namespace Orchestra.Site.Models.Layout
{
    public class LayoutModel
    {
        public LayoutModel(IList<Division> menu)
        {
            Menu = menu;
        }

        public IList<Division> Menu { get; private set; }
    }
}