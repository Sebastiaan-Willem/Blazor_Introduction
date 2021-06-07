using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Introduction.Shared
{
    public partial class NavMenu
    {
        //code in partial class instead of the razor file "NavMenu.razor" to separate C# code from markup 

        private bool collapseNavMenu = true;

        private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        private void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }
    }
}
