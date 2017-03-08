# IA.SDK
SDK library for the IA Framework

## Addon tutorial
There are a few steps you have to set up a SDK addon project.
1: Set up a C# class library project.
2: Download the SDK and add it as a dependency
3: Add this snippet as your starting class.
```csharp
class Addon : BaseAddon {
  public void Create(IAddonInstance addon) {
    // create addon here.
    return addon;
  }
}
```
use the addon object to add commands and modules, it will be initialized on runtime.

## Notable Bots using this system
Galaco (https://github.com/velddev/galaco)
Miki (https://github.com/velddev/miki)
