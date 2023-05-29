using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OutwardModTemplate
{
    [BepInPlugin(GUID, NAME, VERSION)]
    public class StormCancer_CustomQuests : BaseUnityPlugin
    {
        // Choose a GUID for your project. Change "myname" and "mymod".
        public const string GUID = "stormcancer.customquests";
        // Choose a NAME for your project, generally the same as your Assembly Name.
        public const string NAME = "StormCancer-CustomQuests";
        // Increment the VERSION when you release a new version of your mod.
        public const string VERSION = "1.0.0";

        // For accessing your BepInEx Logger from outside of this class (MyMod.Log)
        internal static ManualLogSource Log;

        // If you need settings, define them like so:
        public static ConfigEntry<bool> ExampleConfig;

        // Awake is called when your plugin is created. Use this to set up your mod.
        internal void Awake()
        {
            Log = this.Logger;
            Log.LogMessage($"Hello world from {NAME} {VERSION}!");

            new Harmony(GUID).PatchAll();
        }
    }


}
