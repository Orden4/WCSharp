# Versioning

The latest version of War3Net is not currently supported. Due to new support being added for additional functionality, the Save/Load will be redesigned from scratch, and the existing all-in-one package will be split into separate packages with some dependencies between them where necessary. These split packages will contain the old, pre-5.0 versions, as well as the new versions.

The new version will be out soon (hopefully before April) and will provide several new, powerful features, such as:
- Fully functional JSON converter that can serialize/deserialize (generic) typed classes, lists and dictionaries
- Save/Load system backed by JSON conversion, meaning you can trivially store complex data mappings
- Sync system backed by JSON conversion, meaning you can trivially send complex data to all clients
- DataTime system, allowing you to determine the current time for each player, as well as a synchronised time across all players

# Development

Currently, this library is still on active development, and expect a lot of new features as well as breaking changes. In the coming weeks/months, I'll be looking into improving all of the existing systems, as well as evaluating the need for more systems.

The following systems are due for re-evaluation (may or may not result in changes):
- Buff system
- Dummy system
- Lightning system
- Save/Load system

The following systems are due for changes (may be added to at a later time):
- Knockback system
    - Handling of trees and other destructibles
    - Optional handling of impact events
    - Re-evaluate merging of knockback forces

# WCSharp

This is a set of libraries designed to assist in the WarCraft 3 mapmaking using C#. For actual compiling and running of a WarCraft 3 map using C#, please refer to the information found in [this thread](https://www.hiveworkshop.com/threads/c-mapmaking-in-csharp.317839/). There is also a quick setup that I use myself on the wiki.

In order to use these systems, simply add the WCSharp NuGet package(s) via Visual Studio.

For information on the individual systems provided by these libraries, please check out the wiki!

Feel free to report bugs, make suggestions or request features!
