using System.Collections.Generic;
using ProcessDynamicModel.Model;

namespace ProcessDynamicModel.UserModel.Abstract
{
    interface IBranch
    {
        List<Gate> GetAllGate();
        Gate GetSingleGate(string gateName);
    }
   
}
