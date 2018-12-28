using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models {
    public class Level01 : Level {
        public Level01() {
            AsstesList.Add(new Tray("tray.png", new Size {Width = 1024, Height = 64}));
            var trayGateList = new List<Gate>();
            trayGateList.Add(new GateAND("symbol_and.png", new Size {Width = 48, Height = 48}, new Position {Height = 8}));
            trayGateList.Add(new GateAND("symbol_nand.png", new Size {Width = 48, Height = 48}, new Position {Height = 8}));
            foreach(var gate in trayGateList) {
                gate.Position.Width = (Canvas.Width / 2) - (trayGateList.Count * gate.Size.Width / 2) + (trayGateList.IndexOf(gate) * gate.Size.Width);
                AsstesList.Add(gate);
            }
            Harness.SaveGame();
        }
    }
}
