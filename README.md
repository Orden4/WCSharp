# Development

Currently, this library is still on active development, and expect a lot of new features as well as breaking changes. In the coming weeks/months, I'll be looking into improving all of the existing systems, as well as evaluating the need for more systems.

The following systems are due for re-evaluation (may or may not result in changes):
- Buff system
- Dummy system
- Lightning system
- Save/load system

The following systems are due for changes (may be added to at a later time):
- Missile system
    - Add support for curved trajectories and spinning projectiles
    - Add support for homing projectiles
    - Will likely separate the currently singular Missile class into a number of sub types to better support different features while keeping complexity low and performance high
- Knockback system
    - Handling of trees and other destructibles
    - Optional handling of impact events
    - Re-evaluate merging of knockback forces

# WCSharp

This is a set of libraries designed to assist in the WarCraft 3 mapmaking using C#. For actual compiling and running of a WarCraft 3 map using C#, please refer to the information found in [this thread](https://www.hiveworkshop.com/threads/c-mapmaking-in-csharp.317839/). There is also a quick setup that I use myself on the wiki.

In order to use these systems, simply add the WCSharp NuGet package(s) via Visual Studio.

For information on the individual systems provided by these libraries, please check out the wiki!

Feel free to report bugs, make suggestions or request features!
