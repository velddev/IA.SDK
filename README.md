# IA.SDK
SDK library for the IA Framework

## Addon tutorial
There are a few steps you have to set up a SDK addon project.<br>
1: Set up a C# class library project.<br>
2: Download the SDK and add it as a dependency<br>
3: Add this snippet as your starting class.<br>
```csharp
class Addon : BaseAddon {
  public void Create(IAddonInstance addon) {
    // create addon here.
    return addon;
  }
}
```
use the addon object to add commands and modules, it will be initialized on runtime.<br>

## Notable Bots using this system
Galaco (https://github.com/velddev/galaco)<br>
Miki (https://github.com/velddev/miki)<br>
