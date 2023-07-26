using UnityEditor;

public class Builder
{
    public static void BuildAndroidPlayer()
    {
        BuildPipeline.BuildPlayer(new BuildPlayerOptions()
        {
            scenes = new string[] { "Assets/Scenes/SampleScene.unity" },
            locationPathName = "app.apk",
            target = BuildTarget.Android,
            options = BuildOptions.None
        });
    }
}
