@echo off
SET "ProjectName=ButcherCounters"
SET "SolutionDir=C:\Users\robin\Desktop\Games\RimWorld Modding\Source\ButcherCounters\Source"
SET "RWModsDir=D:\SteamLibrary\steamapps\common\RimWorld\Mods"
@echo on

rmdir /S /Q "%RWModsDir%\$(ProjectName)\Assemblies\"
xcopy /S /Y "%SolutionDir%\..\About\*" "%RWModsDir%\%ProjectName%\About\"
xcopy /S /Y "%SolutionDir%\..\Defs\*" "%RWModsDir%\%ProjectName%\Defs\"
xcopy /S /Y "%SolutionDir%\..\Patches\*" "%RWModsDir%\%ProjectName%\Patches\"