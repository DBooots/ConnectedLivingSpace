using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConnectedLivingSpace
{
    class CLSKerbal
    {
    	ProtoCrewMember kerbal;

    	public CLSKerbal(ProtoCrewMember kerbal) {
    		this.kerbal = kerbal;
    	}

    	public ProtoCrewMember Kerbal
        {
            get
            {
                return this.kerbal;
            }
        }
    }
}