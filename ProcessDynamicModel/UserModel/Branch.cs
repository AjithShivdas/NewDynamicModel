using System.Collections.Generic;
using ProcessDynamicModel.Helpers;
using ProcessDynamicModel.Model;
using ProcessDynamicModel.UserModel.Abstract;

namespace ProcessDynamicModel.UserModel
{
    class Branch : IBranch
    {
        public List<Gate> GetAllGate()
        {
            var AllGates = GateMatrix.GetGateDetails();
            return AllGates;
        }

        public Gate GetSingleGate(string gateName)
        {
            var list = GetAllGate();
            var singlegate = GetAllGate().Find(x => x.GateName == gateName);
            return singlegate;
        }


    }
}
