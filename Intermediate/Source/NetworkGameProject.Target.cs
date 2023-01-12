using UnrealBuildTool;

public class NetworkGameProjectTarget : TargetRules
{
	public NetworkGameProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("NetworkGameProject");
	}
}
