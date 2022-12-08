# Mount & Blade II: Bannerlord Native Manager
This project is a hook into the managed/native interface for Mount & Blade II: Bannerlord, allowing you to interact with the game's internals.

## CodeGen.cs
`CodeGen` generates wrapper code around the native interfaces to enhance the ease of modding. Code within `Events` & `Interfaces` is generated and thus can be largely ignored.

## NativeManager.cs
`NativeManager` is a helper class for interacting with the native interface. In order for the generated APIs/Events to work, you need to run the `CollectReferences` method ahead of time. This collects the native references into dictionaries used by the generated code.  

## Note
Please be aware that this project is not affiliated with or endorsed by the game's developers. Use it at your own risk.
