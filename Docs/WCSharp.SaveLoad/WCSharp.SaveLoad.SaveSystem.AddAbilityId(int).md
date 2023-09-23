#### [WCSharp.SaveLoad](index.md 'index')
### [WCSharp.SaveLoad](WCSharp.SaveLoad.md 'WCSharp.SaveLoad').[SaveSystem](WCSharp.SaveLoad.SaveSystem.md 'WCSharp.SaveLoad.SaveSystem')

## SaveSystem.AddAbilityId(int) Method

Adds an additional ability id for use as temporary data storage.  
  
By default, you have 6000 characters to use as storage. If you approach that limit, expand the ability ids used at the start of the game using this method.  
  
This should be done upon map start, before anything attempts to use the SaveSystem.  
  
The default includes most of the Human abilities:  
  
Amls, Ahan, Aroc, Amic, Amil, Aclf, Acmg, Adef, Adis, Afbt, Afbk, Aflk, Afla, Agyb, Afsh,  
            Ahea, Ahlh, Ainf, Aivs, Ahri, Amdf, Adts, Apxf, Aply, Ahrp, AHta, Aslo, Asps, Asth, Ahsb

```csharp
public static void AddAbilityId(int abilityId);
```
#### Parameters

<a name='WCSharp.SaveLoad.SaveSystem.AddAbilityId(int).abilityId'></a>

`abilityId` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')