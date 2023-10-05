#### [WCSharp.SaveLoad](README.md 'README')
### [WCSharp.SaveLoad](WCSharp.SaveLoad.md 'WCSharp.SaveLoad')

## SaveSystem Class

Contains logic shared between all different generic [SaveSystem&lt;T&gt;](WCSharp.SaveLoad.SaveSystem_T_.md 'WCSharp.SaveLoad.SaveSystem<T>') instances.

```csharp
public class SaveSystem
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SaveSystem

| Methods | |
| :--- | :--- |
| [AddAbilityId(int)](WCSharp.SaveLoad.SaveSystem.AddAbilityId(int).md 'WCSharp.SaveLoad.SaveSystem.AddAbilityId(int)') | Adds an additional ability id for use as temporary data storage.<br/><br/><br/>By default, you have 6000 characters to use as storage. If you approach that limit, expand the ability ids used at the start of the game using this method.<br/><br/>This should be done upon map start, before anything attempts to use the SaveSystem.<br/><br/>The default includes most of the Human abilities:<br/><br/>Amls, Ahan, Aroc, Amic, Amil, Aclf, Acmg, Adef, Adis, Afbt, Afbk, Aflk, Afla, Agyb, Afsh,<br/>            Ahea, Ahlh, Ainf, Aivs, Ahri, Amdf, Adts, Apxf, Aply, Ahrp, AHta, Aslo, Asps, Asth, Ahsb |
