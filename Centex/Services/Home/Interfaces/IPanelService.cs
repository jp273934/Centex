using Centex.Models;
using System.Collections.Generic;

namespace Centex.Services.Home.Interfaces
{
    public interface IPanelService
    {
        IEnumerable<Panel> GetPanels();
    }
}