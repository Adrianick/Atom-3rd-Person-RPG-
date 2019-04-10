// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ATOMThirdPersonRPGEditorTarget : TargetRules
{
	public ATOMThirdPersonRPGEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ATOMThirdPersonRPG");
	}
}
