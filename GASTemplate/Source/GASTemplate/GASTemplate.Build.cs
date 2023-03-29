// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GASTemplate : ModuleRules
{
	public GASTemplate(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[]
		{
			// Default Modules
			"Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "EnhancedInput"
			
			// Additional Modules
		});
		
		PrivateDependencyModuleNames.AddRange(new string[]
		{
			// Default Modules

			// Additional Modules
			
			/* For Gameplay Ability System */
			"GameplayTags",
			"GameplayAbilities",
			"GameplayTasks",
			
			/* For Modular Gameplay Features */
			"ModularGameplay",
			"GameFeatures",
			
			/* For SimpleMGF Plugin */
			"SimpleMGFGame",
		});
	}
}
