// Example mod definition by Nathan Schmitt

// NOTE: You must include the game's assembly in your project to reference the game's code.
// The IBX.Mods namespace contains all the classes and interfaces required to create a mod.
// More information about the IBX.Mods namespace can be found in the documentation.
using IBX.Mods;

// You can add more using statements if you wish, just keep in mind that the game's mod loader
// will refuse to load a mod that is referencing non-whitelisted assemblies.
//
// Here is a list of white-listed assemblies your project can reference:
// - mscorelib
// - System
// - System.Core
// - System.Runtime
// - GodotSharp
// - The game's main assembly [REQUIRED] (contains the game's code and mod loader)
//
// If there is a specific assembly you would like to reference that is not on this list, please
// create an issue on this repository or contact the developers on the official Discord server.
//
// In the meantime, you can copy the code from the assembly you are trying to reference and use it
// in your mod directly. This is not ideal, but it is a workaround until we can add more assemblies
// to the white-list.

// You can use whatever namespace you want, but it is recommended to use the name of your mod.
namespace ExampleMod
{
    /// <summary>
    /// All mods are required to have a mod definition. This is the main file for our mod.
    /// There should only ever be one mod definition per mod. Multiple mod definitions
    /// will cause unpredictable and undefined behavior. Mod definitions are loaded automatically 
    /// by the game's internal mod loader at startup. All other mod components are managed
    /// only when the mod is enabled.
    /// 
    /// Mods must implement the <see cref="IUserModDefinition"/> interface which contains the mod's
    /// metadata as well as a <see cref="SharedModInstance"/>.
    /// </summary>
    internal class ExampleMod : IUserModDefinition
    {
        /// <summary>
        /// You are required to create a new instance of the <see cref="ModInstance"/> class.
        /// </summary>
        /// 
        /// <remarks>
        /// Inside the game's code, the <see cref="ModInstance"/> class defines two fields: a 
        /// calling assembly and a reference to an internal "mod object."
        /// 
        /// These are used by the game to manage mods, execute their scripts, and facilitate and 
        /// validate extensions. The mod loader will handle the loading and initialization of your 
        /// mod to a certain degree using the mod's manifest file, but it is not smart enough to 
        /// automatically determine the mod's assembly. Under the hood, when you construct a 
        /// <see cref="ModInstance"/>(), you are telling the game what the mod's "Calling Assembly" 
        /// is as well as associating it with the appropriate internal mod object. This process 
        /// ensures your the mod is correctly identified, validated, and integrated into the game.
        /// 
        /// Additionally, by manually creating the ModInstance, you maintain control over the mod’s lifecycle 
        /// and interactions. This approach allows you to request operations from the mod loader directly,
        /// ensuring that only properly initialized and enabled mods can make requests.
        /// It also helps enforce validation and control mechanisms, improving the stability and security 
        /// of the modding system.
        /// </remarks>
        public static readonly ModInstance Instance = new();

        /// <summary>
        /// This property is required by the <see cref="IUserModDefinition"/> interface to
        /// provide the <see cref="ModInstance"/> to the game and mod loader.
        /// </summary>
        public ModInstance SharedModInstance { get { return Instance; } }

        /// <summary>
        /// The name of the mod.
        /// </summary>
        /// <remarks>
        /// This is different from the value defined in the mod's manifest file.
        /// This will only be displayed in the debugger and log files.
        /// </remarks>
        public string Name => "Example Mod";

        /// <summary>
        /// The version of the mod.
        /// </summary>
        /// <remarks>
        /// This is different from the value defined in the mod's manifest file.
        /// This will only be displayed in the debugger and log files.
        /// </remarks>
        public string Description => "An example mod for documentation.";

        /// <summary>
        /// The author of the mod.
        /// </summary>
        /// <remarks>
        /// This is different from the value defined in the mod's manifest file.
        /// This will only be displayed in the debugger and log files.
        /// </remarks>
        public string Author => "Nathan Schmitt";

        /// <summary>
        /// The copyright notice of the mod.
        /// You can use this to specify the year the mod was created and whom it belongs to.
        /// </summary>
        /// <remarks>
        /// This is different from the value defined in the mod's manifest file.
        /// This will only be displayed in the debugger and log files.
        /// </remarks>
        public string Copyright => "Copyright (C) 2024 Nathan Schmitt";
    }
}