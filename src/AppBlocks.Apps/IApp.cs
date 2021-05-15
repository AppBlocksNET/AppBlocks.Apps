using System.Collections.Generic;

namespace AppBlocks.Apps
{
    public interface IApp
    {
        List<Dictionary<string, object>> App(Dictionary<string, object> parameters = null);
    }
}