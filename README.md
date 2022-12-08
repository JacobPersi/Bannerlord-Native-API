# Mount & Blade II: Bannerlord Manged/Native Interface
This project is a hook into the managed/native interface for Mount & Blade II: Bannerlord, allowing you to interact with the game's internals.

<p align="center">
  <img width="400" height="200" src="https://github.com/JacobPersi/Bannerlord-Natives/blob/main/img/demo.png?raw=true">
</p>

## CodeGen.cs
`CodeGen` generates wrapper code around the native interfaces to enhance the ease of modding. Code within `Events` & `Interfaces` is generated and thus can be largely ignored.

## NativeManager.cs
`NativeManager` is a helper class for interacting with the native interface. In order for the generated APIs/Events to work, you need to run the `CollectReferences` method ahead of time. This collects the native references into dictionaries used by the generated code.  

## Note
Please be aware that this project is not affiliated with or endorsed by the game's developers. Use it at your own risk.

Helpful information:
- Bannerlord Modding Documentation:   https://docs.bannerlordmodding.com/
- Harmony Patching Documentation:     https://harmony.pardeike.net/articles/patching.html
- TaleWorlds Modding Forums:          https://forums.taleworlds.com/index.php?pages/modding/
- Mount and Blade Discord:            https://discordapp.com/invite/mountandblade
- TW Forum - Modding Discord:         https://discordapp.com/invite/ykFVJGQ
