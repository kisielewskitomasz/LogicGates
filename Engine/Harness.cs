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
            try
            {
                using (StreamReader inputFile = new StreamReader(FilePath.Get("save.dat")))
                {
                    string lastLevel = Base64Decode(inputFile.ReadToEnd().TrimEnd());
                    System.Console.WriteLine($"Load level: {lastLevel}");
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
                System.Console.WriteLine($"Save level: {Harness.GameCurrentLevel.ToString()}");
                outputFile.WriteLine(Base64Encode(Harness.GameCurrentLevel.ToString()));
            }
        }

        public static void QuitGame()
        {
            Input.Quit();
        }

        public static void ReloadLevel()
        {
            Type type = Harness.GameCurrentLevel.GetType();
            Harness.GameCurrentLevel = (Level)Activator.CreateInstance(type);
            Harness.RefreshOutput();
        }

        public static void ResetGame()
        {
            Harness.GameCurrentLevel = new Level01();
            Harness.RefreshOutput();
        }

        public static void SimulateLevel()
        {
            System.Console.WriteLine("simulation...");
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