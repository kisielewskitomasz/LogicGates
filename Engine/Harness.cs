using System;
using System.IO;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Models;
using LogicGates.Models.Elements;

namespace LogicGates.Engine
{
    /// <summary>
    /// Handles whole logic of game and connects Input and Output together
    /// </summary>
    public class Harness
    {
        public static Engine.Output EngineOutput { get; set; } = null;
        public static Engine.Input EngineInput { get; set; } = null;
        public static Models.Level GameCurrentLevel { get; set; } = null;

        public Harness()
        {
            EngineOutput = new Engine.Output();
            GameCurrentLevel = new Models.Level00();
            RefreshOutput();
            EngineInput = new Engine.Input();
        }

        public static void RefreshOutput()
        {
            GameCurrentLevel.AsstesList.ForEach((asset) => asset.Render());
            SDL.SDL_RenderPresent(Output.Renderer);
        }

        public static void LoadGame()
        {
            try
            {
                using (StreamReader inputFile = new StreamReader(FilePath.Get("save.dat")))
                {
                    string lastLevel = Base64Decode(inputFile.ReadToEnd().TrimEnd());
                    if (lastLevel.Equals("LogicGates.Models.Level00"))
                    {
                        Harness.GameCurrentLevel = new Level01();
                    }
                    else
                    {
                        Type type = Type.GetType(lastLevel, false);
                        if (type == null)
                        {
                            Harness.GameCurrentLevel = new Level99();
                        }
                        else
                        {
                            Harness.GameCurrentLevel = (Level)Activator.CreateInstance(type);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Harness.GameCurrentLevel = new Level01();
                SaveGame();
            }
            Harness.RefreshOutput();
        }

        public static void SaveGame()
        {
            using (StreamWriter outputFile = new StreamWriter(FilePath.GetNotExisting("save.dat")))
            {
                outputFile.WriteLine(Base64Encode(Harness.GameCurrentLevel.ToString()));
            }
        }

        public static void QuitGame()
        {
            Input.Quit();
        }

        public static void ReloadLevel()
        {
            Harness.GameCurrentLevel = (Level)Activator.CreateInstance(Harness.GameCurrentLevel.GetType());
            Harness.RefreshOutput();
        }

        public static void NextLevel()
        {
            string currentLevel = Harness.GameCurrentLevel.ToString();
            string currentLevelNumber = currentLevel.Substring(currentLevel.Length - 2);
            int currentLevelInt = -1;
            string nextLevelNumber = "";
            string nextLevel = "";
            if (Int32.TryParse(currentLevelNumber, out currentLevelInt))
            {
                if (++currentLevelInt < 10)
                    nextLevelNumber = "0" + currentLevelInt.ToString();
                else
                    nextLevelNumber = currentLevelInt.ToString();
            }
            else
            {
                Harness.GameCurrentLevel = new Level00();
            }
            nextLevel = "LogicGates.Models.Level" + nextLevelNumber;

            Type type = Type.GetType(nextLevel, false);
            if (type == null)
                Harness.GameCurrentLevel = new Level99();
            else
            {
                Harness.GameCurrentLevel = (Level)Activator.CreateInstance(type);
                Harness.SaveGame();
            }
            Harness.RefreshOutput();
        }

        public static void ResetGame()
        {
            Harness.GameCurrentLevel = new Level01();
            Harness.SaveGame();
            Harness.RefreshOutput();
        }

        public static void SimulateLevel()
        {
            foreach (var element in GameCurrentLevel.ElementsList)
            {
                foreach (var pin in element.PinsList)
                {
                    if (pin.isConnected == false)
                    {
                        return;
                    }
                }

                foreach (var pin in element.PinsList)
                {
                    if ((pin.ParentConnection != null) && (pin.ParentConnection.State == Defs.Connection.HighImpedance) && !(pin.ParentConnection.isConnectedWithGateOutput()))
                    {
                        pin.ParentConnection.State = (Defs.Connection)element.CurrentTexture;
                        foreach(var wire in pin.ParentConnection.WiresList)
                        {
                            wire.CurrentTexture = (int)wire.Type + (2 * ((int)pin.ParentConnection.State + 1));
                            Engine.Harness.RefreshOutput();
                        }
                    }
                }
            }

            while (Harness.GameCurrentLevel.ConnectionsList.Find(x => (x.State == Defs.Connection.HighImpedance)) != null)
            {
                foreach (var gate in GameCurrentLevel.GatesList)
                {
                    if (!(gate.IsInTray()))
                    {
                        foreach (var pin in gate.PinsList)
                        {
                            if (pin.isConnected == false)
                            {
                                return;
                            }
                        }

                        gate.ComputeOutput();
                    }
                }
            }

            foreach (var lamp in Harness.GameCurrentLevel.LampsList)
            {
                int potential = 0;
                foreach (var pin in lamp.PinsList)
                {
                    potential += (int)pin.ParentConnection.State;
                }

                if (potential == 1)
                    lamp.ChangeStateToHigh();
            }

            bool isFinished = false;
            foreach (var lamp in Harness.GameCurrentLevel.LampsList)
            {
                if (lamp.CurrentTexture == 1)
                    isFinished = true;
                else
                    isFinished = false;
            }


            if (isFinished)
            {
                Harness.GameCurrentLevel.AsstesList.Add(new Models.Images.Completed(new Size(Dimensions.Banner.Width, Dimensions.Banner.Height), new Position((Dimensions.Canvas.Width / 2) - (Dimensions.Banner.Width / 2), (Dimensions.Canvas.Height / 2) - (Dimensions.Banner.Height / 2))));
                Harness.RefreshOutput();
            }
            else
            {
                Harness.GameCurrentLevel.AsstesList.Add(new Models.Images.Retry(new Size(Dimensions.Banner.Width, Dimensions.Banner.Height), new Position((Dimensions.Canvas.Width / 2) - (Dimensions.Banner.Width / 2), (Dimensions.Canvas.Height / 2) - (Dimensions.Banner.Height / 2))));
                Harness.RefreshOutput();
            }
        }

        static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}