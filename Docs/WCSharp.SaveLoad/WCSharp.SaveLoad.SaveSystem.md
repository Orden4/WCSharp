#### [WCSharp\.SaveLoad](README.md 'README')
### [WCSharp\.SaveLoad](WCSharp.SaveLoad.md 'WCSharp\.SaveLoad')

## SaveSystem Class

Contains logic shared between all different generic [SaveSystem&lt;T&gt;](WCSharp.SaveLoad.SaveSystem_T_.md 'WCSharp\.SaveLoad\.SaveSystem\<T\>') instances\.

```csharp
public class SaveSystem
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; SaveSystem

| Methods | |
| :--- | :--- |
| [AddAbilityId\(int\)](WCSharp.SaveLoad.SaveSystem.AddAbilityId(int).md 'WCSharp\.SaveLoad\.SaveSystem\.AddAbilityId\(int\)') |   <b>Deprecated. We now have infinite storage space and this is unnecessary.</b>  <b>Only use this for backwards compatability with older saves for your map.</b>  Adds an additional ability id for use as temporary data storage.  By default, you have 6000 characters to use as storage. If you approach that limit, expand the ability ids used at the start of the game using this method.  This should be done upon map start, before anything attempts to use the SaveSystem.  The default includes most of the Human abilities:  Amls, Ahan, Aroc, Amic, Amil, Aclf, Acmg, Adef, Adis, Afbt, Afbk, Aflk, Afla, Agyb, Afsh,             Ahea, Ahlh, Ainf, Aivs, Ahri, Amdf, Adts, Apxf, Aply, Ahrp, AHta, Aslo, Asps, Asth, Ahsb |
