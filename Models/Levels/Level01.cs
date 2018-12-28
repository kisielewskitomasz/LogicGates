using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models {
    public class Level01 : Level {
        public Level01() {
            AsstesList.Add(new Screens.Tray(new Size {Width = 1024, Height = 64}));
            var trayGateList = new List<Gate>();
            trayGateList.Add(new GateAND(new Size {Width = 48, Height = 48}, new Position {Height = 8}));
            trayGateList.Add(new GateNAND(new Size {Width = 48, Height = 48}, new Position {Height = 8}));
            foreach(var gate in trayGateList) {
                gate.Position.Width = (Canvas.Width / 2) - (trayGateList.Count * gate.Size.Width / 2) + (trayGateList.IndexOf(gate) * gate.Size.Width);
                AsstesList.Add(gate);
            }
            var logicSourcesList = new List<Elements.Logic>();
            logicSourcesList.Add(new Elements.LogicOne(new Size {Width = 72, Height = 72}, new Position {Width = 72}));
            logicSourcesList.Add(new Elements.LogicZero(new Size {Width = 72, Height = 72}, new Position {Width = 72}));
            foreach(var source in logicSourcesList) {
                source.Position.Height = (Canvas.Height / 2) - (logicSourcesList.Count * source.Size.Height / 2) + (logicSourcesList.IndexOf(source) * source.Size.Height);
                AsstesList.Add(source);
            }
            Harness.SaveGame();
        }
    }
}
