using System.Collections.Generic;
using ProcessDynamicModel.Model;

namespace ProcessDynamicModel.Helpers
{
    public static class GateMatrix
    {
        public static List<Gate> GetGateDetails()
        {
            return new List<Gate>
            {

                new Gate { Id= 0, IsOpen = true , LeftGateName = "G2"  ,RightGateName = "G3", GateName="G1" , LeftOutlet= string.Empty ,RightOutlet = string.Empty},
                new Gate { Id= 1, IsOpen = false , LeftGateName = "G4"  ,RightGateName = "G5" , GateName="G2" , LeftOutlet= string.Empty ,RightOutlet = string.Empty  },
                new Gate { Id= 2, IsOpen = false , LeftGateName = "G6"   ,RightGateName = "G7"  , GateName="G3" , LeftOutlet= string.Empty ,RightOutlet = string.Empty  },
                new Gate { Id= 3, IsOpen = true , LeftGateName = "G8"  ,RightGateName ="G9", GateName="G4" , LeftOutlet= string.Empty ,RightOutlet = string.Empty  },
                new Gate { Id= 4, IsOpen = true ,  LeftGateName = "G10"  ,RightGateName ="G11"  , GateName ="G5" , LeftOutlet= string.Empty ,RightOutlet = string.Empty  },
                new Gate { Id= 5, IsOpen = true  , LeftGateName ="G12"  ,RightGateName = "G13"  , GateName ="G6" , LeftOutlet= string.Empty ,RightOutlet = string.Empty  },
                new Gate { Id= 6, IsOpen = true  , LeftGateName = "G14" ,RightGateName = "G15", GateName="G7" , LeftOutlet= string.Empty ,RightOutlet = string.Empty  },
                new Gate { Id= 7, IsOpen = false , LeftGateName = string.Empty ,RightGateName = string.Empty,  GateName ="G8" , LeftOutlet= "A" ,RightOutlet ="B"  },
                new Gate { Id= 8, IsOpen = true ,  LeftGateName = string.Empty ,RightGateName = string.Empty , GateName ="G9" , LeftOutlet="C" ,RightOutlet = "D"  },
                new Gate { Id= 9, IsOpen = false , LeftGateName = string.Empty ,RightGateName = string.Empty , GateName ="G10" , LeftOutlet="E",RightOutlet = "F"  },
                new Gate { Id= 10, IsOpen = false ,  LeftGateName = string.Empty ,RightGateName = string.Empty,  GateName="G11" , LeftOutlet= "G" ,RightOutlet = "H" },
                new Gate { Id= 11, IsOpen = true  ,  LeftGateName = string.Empty ,RightGateName = string.Empty,  GateName="G12" , LeftOutlet= "I" ,RightOutlet = "J"  },
                new Gate { Id= 12, IsOpen = true  ,  LeftGateName = string.Empty ,RightGateName = string.Empty,  GateName="G13" , LeftOutlet= "K" ,RightOutlet = "L"  },
                new Gate { Id= 13, IsOpen = false  , LeftGateName = string.Empty ,RightGateName = string.Empty,  GateName="G14" , LeftOutlet= "M" ,RightOutlet = "N" },
                new Gate { Id= 14, IsOpen = true  ,  LeftGateName = string.Empty ,RightGateName = string.Empty,  GateName="G15" , LeftOutlet= "O" ,RightOutlet = "P"  },
            };

        }
    }
}
