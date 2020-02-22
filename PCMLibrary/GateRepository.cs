using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCMLibrary
{
    public class GateRepository
    {
        private List<Gate> GateList;

        public GateRepository()
        {
            GateList = new List<Gate>();
            GateList.Add(new Gate(31, "North Pass"));
            GateList.Add(new Gate(32, "East Pass"));
            GateList.Add(new Gate(33, "South Pass"));
            GateList.Add(new Gate(34, "West Pass"));
        }

        public List<Gate> GetGateList()
        {
            return GateList;
        }

        public void AddNewGate(int newGateId, string newGateName)
        {
                if (GetGateCodeByID(newGateId) == null)
                {
                GateList.Add(new Gate(newGateId, newGateName));
                }
        }

        public void RemoveGate(int removeGateId)
        {
            if (GetGateCodeByID(removeGateId) != null)
            {
                for (int i = 0; i < GateList.Count; i++)
                {
                    if (removeGateId == GateList[i].GateId)
                    {
                        GateList.RemoveAt(i);
                        return;
                    }
                }
            }
        }

        public string GetGateCodeByID(int gateId)
        {
            foreach (var item in GateList)
            {
                if (gateId == item.GateId)
                {
                    return item.GateName;
                }
            }
            return null;
        }

        public object[] GetAllGateNameAndCodeArray()
        {
            int arrayLenght = GateList.Count;
            object[] gateListArray = new object[arrayLenght];
            for (int i = 0; i < arrayLenght; i++)
            {
                gateListArray[i] = GateList[i];
            }

            return gateListArray;
        }
    }
}
