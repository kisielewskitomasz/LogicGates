using System;
using System.IO;
using System.Collections.Generic;
using SDL2;
using LogicGates.Common;
using LogicGates.Models;

namespace LogicGates.Engine
{
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
            System.Console.WriteLine("Load game");
            try
            {
                System.Console.WriteLine("load file");
                using (StreamReader inputFile = new StreamReader(FilePath.Get("save.dat")))
                {
                    string lastLevel = inputFile.ReadToEnd().TrimEnd();
                    if (lastLevel.Equals("LogicGates.Models.Level00"))
                        Harness.GameCurrentLevel = new Level01();
                    else
                    {
                        Type type = Type.GetType(lastLevel, false);
                        if (type == null)
                            Harness.GameCurrentLevel = new Level99();
                        else
                            Harness.GameCurrentLevel = (Level)Activator.CreateInstance(type);
                    }

                    Harness.RefreshOutput();
                }
            }
            catch (FileNotFoundException)
            {
                SaveGame();
            }
        }

        public static void SaveGame()
        {
            using (StreamWriter outputFile = new StreamWriter(FilePath.GetNotExisting("save.dat")))
            {
                outputFile.WriteLine(Harness.GameCurrentLevel);
            }
        }

        public static void QuitGame()
        {
            Harness.SaveGame();
            Input.Quit();
        }

        public static void ResetGame()
        {
            Harness.GameCurrentLevel = new Level01();
            Harness.RefreshOutput();
        }
    }
}