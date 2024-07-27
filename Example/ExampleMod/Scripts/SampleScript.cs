// Example mod script by Nathan Schmitt

// This script is an example of a mod script that can be used to add functionality to the game.
// This script will print messages to the console when the mod is enabled, disabled, and once every X frames.

using Godot;
using IBX.Mods;

// You can use whatever namespace you want, but it is recommended to use the name of your mod.
namespace ExampleMod
{
    /// <summary>
    /// Mod scripts are used to add functionality to the game without overriding any 
    /// already existing functionality. If you would like to override existing 
    /// functionality, you should create a new class that inherits from the various 
    /// "UserModExtension" classes you would like to override.
    /// 
    /// 1. Mod scripts are loaded automatically by the game's internal mod loader when the mod is enabled.
    /// 2. Mod scripts are executed one at a time in the order that they were loaded.
    /// 3. There is no way to guarantee the order in which mod scripts are loaded for performance reasons.
    /// 4. It is the responsibility of the mod developer to keep track of the order in which mod scripts are loaded.
    /// </summary>
    public sealed class SampleScript : IUserModScript
    {
        /// <summary>
        /// This method is called by the mod loader when the mod is enabled.
        /// </summary>
        /// <remarks>
        /// Use this method to initialize your mod and set up any necessary resources.
        /// </remarks>
        public void OnEnable()
        {
            GD.Print("Hello from mod script 1!");

            ExampleMod.Instance.RequestDisable();
        }

        /// <summary>
        /// This method is called by the mod loader when the mod is disabled.
        /// </summary>
        /// <remarks>
        /// Use this method to clean up any resources and save any necessary data.
        /// </remarks>
        public void OnDisable()
        {
            GD.Print("Goodbye from mod script 1!");
            ExampleMod.Instance.RequestReload();
        }

        /// <summary>
        /// This method is called by the mod loader every frame
        /// </summary>
        /// <param name="delta">The delta time between frames</param>
        /// <remarks>
        /// Use this method to update your mod's logic every frame if necessary.
        /// </remarks>
        public void OnProcess(double delta)
        {
            GD.Print("MOD PROCESSING 1!");
        }

        /// <summary>
        /// This method is called by the mod loader every physics update
        /// </summary>
        /// <param name="delta">The delta time between updates</param>
        /// <remarks>
        /// Use this method to update your mod's physics logic every physics update if necessary.
        /// </remarks>
        public void OnPhysicsProcess(double delta)
        {
            GD.Print("MOD PHYSICS PROCESSING 1!");
        }
    }
}
