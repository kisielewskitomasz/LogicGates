using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;

namespace LogicGates.Models {
    public class Level01 : Level {
        public Level01() {
            AsstesList.Add(new Screens.Tray());

            var trayGatesList = new List<Gate>();
            trayGatesList.Add(new GateAND(new Position {Height = 0}));
            trayGatesList.Add(new GateNAND(new Position {Height = 0}));
            foreach(var gate in trayGatesList) {
                gate.Position.Width = (Canvas.Width / 2) - (trayGatesList.Count * gate.Size.Width / 2) + (trayGatesList.IndexOf(gate) * gate.Size.Width);
                AsstesList.Add(gate);
            }

            var logicSourcesList = new List<Elements.Logic>();
            logicSourcesList.Add(new Elements.LogicOne(new Position {Width = 72}));
            logicSourcesList.Add(new Elements.LogicZero(new Position {Width = 72}));
            foreach(var source in logicSourcesList) {
                source.Position.Height = (Canvas.Height / 2) - (logicSourcesList.Count * source.Size.Height / 2) + (logicSourcesList.IndexOf(source) * source.Size.Height);
                AsstesList.Add(source);
            }

            var lampsList = new List<Elements.Lamp>();
            lampsList.Add(new Elements.LampOn(new Position {Width = Canvas.Width - (72 * 3)}));
            lampsList.Add(new Elements.LampOff(new Position {Width = Canvas.Width - (72 * 3)}));
            foreach(var lamp in lampsList) {
                lamp.Position.Height = (Canvas.Height / 2) - (lampsList.Count * lamp.Size.Height / 2) + (lampsList.IndexOf(lamp) * lamp.Size.Height);
                AsstesList.Add(lamp);
            }

            AsstesList.Add(new Elements.Ground(new Position {Width = Canvas.Width - (72 * 2), Height = Canvas.Height - (72 * 3)}));

            Harness.SaveGame();
        }
    }
}
