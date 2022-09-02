using UnityEngine;
using UnityEditor;

[CustomEditor (typeof (MapGenerator))]
public class NewBehaviourScript : Editor
{
    public override void OnInspectorGUI()
    {
        MapGenerator mapGen = (MapGenerator)target;

        if (DrawDefaultInspector()) {
            if (mapGen.autoUpdate)
            {
                mapGen.DrawMapInEditor();
            }
        };

        if (GUILayout.Button("Generate"))
        {
            mapGen.DrawMapInEditor();
        }
    }
}
