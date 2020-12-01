using UnityEngine;
using UnityEditor;
using System.Collections;
 
class EditorScrips : EditorWindow
{
 
    [MenuItem("Play/PlayMe _%h")]
    public static void RunMainScene()
    {
        EditorApplication.OpenScene("Assets/MainScene.unity");
        EditorApplication.isPlaying = true;
    }
}