using mkr_1.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkr_1.Interfaces
{
    public interface IElementState
    {
        string Render(LightElementNode element);
    }
}
