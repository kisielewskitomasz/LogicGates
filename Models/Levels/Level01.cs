using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;
using LogicGates.Models.Elements;

namespace LogicGates.Models
{
    public class Level01 : Level
    {
        public Level01()
        {
            AsstesList.Add(new Images.Tray());

            AsstesList.Add(new Images.Reload(new Position(Canvas.Width - 72, 0)));
            AsstesList.Add(new Images.Simulate(new Position(0, 0)));

            var trayGatesList = new List<Gate>();
            trayGatesList.Add(new GateAND(new Position(0, 0)));
            // trayGatesList.Add(new GateNAND(new Position(0, 0)));
            trayGatesList.Add(new GateNOT(new Position(0, 0)));
            foreach (var gate in trayGatesList)
            {
                gate.Position.Width = (Canvas.Width / 2) - (trayGatesList.Count * gate.Size.Width / 2) - ((trayGatesList.Count - 2) * 8) + (trayGatesList.IndexOf(gate) * (gate.Size.Width + 8));
                AsstesList.Add(gate);
            }

            var logicSourcesList = new List<Source>();
            logicSourcesList.Add(new Source(new Position(18 + 72, 0), Defs.Element.High));
            logicSourcesList.Add(new Source(new Position(18 + 72, 0), Defs.Element.Low));
            foreach (var source in logicSourcesList)
            {
                source.Position.Height = (Canvas.Height / 2) - (logicSourcesList.Count * source.Size.Height / 2) - 18 + (logicSourcesList.IndexOf(source) * source.Size.Height);
                AsstesList.Add(source);
            }

            var lampsList = new List<Lamp>();
            // lampsList.Add(new LampOn(new Position(Canvas.Width - (18 + 72 * 4), 0)));
            lampsList.Add(new Lamp(new Position(Canvas.Width - (18 + 72 * 4), 0), Defs.Element.Low));
            foreach (var lamp in lampsList)
            {
                lamp.Position.Height = (Canvas.Height / 2) - (lampsList.Count * lamp.Size.Height / 2) - 18 + (lampsList.IndexOf(lamp) * lamp.Size.Height);
                AsstesList.Add(lamp);
            }

            var groundList = new List<Ground>();
            // groundList.Add(new Ground(new Position(Canvas.Width - (18 + 72 * 2), 0)));
            groundList.Add(new Ground(new Position(Canvas.Width - (18 + 72 * 2), 0)));
            foreach (var ground in groundList)
            {
                ground.Position.Height = (Canvas.Height / 2) - (groundList.Count * ground.Size.Height / 2) - 18 + (groundList.IndexOf(ground) * ground.Size.Height);
                AsstesList.Add(ground);
            }



            Harness.SaveGame();
        }
    }
}
