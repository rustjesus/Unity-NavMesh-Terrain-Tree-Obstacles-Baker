using System.Collections;
using System.Collections.Generic;
using TMG_EditorTools;
using UnityEditor;
using UnityEngine;

public class SetTerrainObstaclesEditor : EditorWindow
{

    [MenuItem("Tools/Set Terrain Tree Obstacles")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow<SetTerrainObstaclesEditor>("Set Tree Terrain Obstacles");
    }

    private void OnGUI()
    {
        GUILayout.Label("Set Tree Terrain Obstacles", EditorStyles.boldLabel);

        if (GUILayout.Button("Bake"))
        {
            BakeObstacles();
        }
    }

    private void BakeObstacles()
    {
        // Call the function to set terrain obstacles
        SetTerrainObstaclesStatic.BakeTreeObstacles();
    }
}
