﻿using System.Linq;
using Cim.Eap.Tx;
using Secs4Net;
namespace Cim.Eap {
    partial class Driver {
        void EQP_SlotMapReport(SecsMessage msg) {
            byte portNo = (byte)msg.SecsItem.Items[2].Items[0].Items[1].Items[0];
            string carrierID = msg.SecsItem.Items[2].Items[0].Items[1].Items[1].ToString().Trim();
            var mapItem = msg.SecsItem.Items[2].Items[0].Items[1].Items[2].Items;
        }
    }
}