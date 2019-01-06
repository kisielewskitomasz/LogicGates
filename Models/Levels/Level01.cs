using System;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Engine;
using LogicGates.Models.Elements;

namespace LogicGates.Models
{
    /// <summary>
    /// Extends Level as Level01
    /// </summary>
    public class Level01 : Level
    {
        public Level01()
        {
            AsstesList.Add(new Images.Tray());

            AsstesList.Add(new Images.Reload(new Position(Dimensions.Canvas.Width - Dimensions.Element.Width, 0)));
            AsstesList.Add(new Images.Simulate(new Position(0, 0)));

            var trayGatesList = new List<Gate>();
            trayGatesList.Add(new GateAND(new Position(0, 0)));
            // trayGatesList.Add(new GateNAND(new Position(0, 0)));
            trayGatesList.Add(new GateNOT(new Position(0, 0)));
            foreach (var gate in trayGatesList)
            {
                gate.Position.Width = (Dimensions.Canvas.Width / 2) - (trayGatesList.Count * gate.Size.Width / 2) - ((trayGatesList.Count - 2) * 8) + (trayGatesList.IndexOf(gate) * (gate.Size.Width + Dimensions.Space.Width));
                GatesList.Add(gate);
            }

            var logicSourcesList = new List<Source>();
            logicSourcesList.Add(new Source(new Position((Dimensions.Element.Width / 4) + Dimensions.Element.Width, 0), Defs.Element.High));
            logicSourcesList.Add(new Source(new Position((Dimensions.Element.Width / 4) + Dimensions.Element.Width, 0), Defs.Element.Low));
            foreach (var source in logicSourcesList)
            {
                source.Position.Height = (Dimensions.Canvas.Height / 2) - (logicSourcesList.Count * source.Size.Height / 2) - (Dimensions.Element.Height / 4) + (logicSourcesList.IndexOf(source) * source.Size.Height);
                ElementsList.Add(source);
            }

            var lampsList = new List<Lamp>();
            lampsList.Add(new Lamp(new Position(Dimensions.Canvas.Width - ((Dimensions.Element.Width / 4) + Dimensions.Element.Width * 4), 0), Defs.Element.Low));
            foreach (var lamp in lampsList)
            {
                lamp.Position.Height = (Dimensions.Canvas.Height / 2) - (lampsList.Count * lamp.Size.Height / 2) - (Dimensions.Element.Height / 4) + (lampsList.IndexOf(lamp) * lamp.Size.Height);
                LampsList.Add(lamp);
            }

            var groundList = new List<Ground>();
            groundList.Add(new Ground(new Position(Dimensions.Canvas.Width - ((Dimensions.Element.Width / 4) + Dimensions.Element.Width * 2), 0)));
            foreach (var ground in groundList)
            {
                ground.Position.Height = (Dimensions.Canvas.Height / 2) - (groundList.Count * ground.Size.Height / 2) - (Dimensions.Element.Height / 4) + (groundList.IndexOf(ground) * ground.Size.Height);
                ElementsList.Add(ground);
            }

            AsstesList.AddRange(ElementsList);
            AsstesList.AddRange(LampsList);
            AsstesList.AddRange(GatesList);
        }
    }
}
