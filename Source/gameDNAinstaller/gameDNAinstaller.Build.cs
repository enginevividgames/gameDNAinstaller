// gameDNA installer
// Created by Patryk Stepniewski
// Copyright (c) 2014-2017 gameDNA Ltd. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class gameDNAinstaller : ModuleRules
	{
		public gameDNAinstaller(ReadOnlyTargetRules Target) : base(Target)
		{	
			PrivateIncludePaths.AddRange(new string[] { "gameDNAinstaller/Private" });

			PublicDependencyModuleNames.AddRange(new string[]{ "Core", "Projects" });

			PrivateDependencyModuleNames.AddRange(
				new string[] {
					"Core",
					"CoreUObject",
					"Engine",
					"Slate",
					"SlateCore",
					"EditorStyle",
					"LevelEditor",
					"UnrealEd",
					"InputCore",
					"HTTP",
					"Json"
				}
			);
		}
	}
}
