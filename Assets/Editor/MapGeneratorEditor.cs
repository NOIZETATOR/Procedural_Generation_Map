using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//Script Editor permettant de modifier l'interface de Unity
// On créee la possibilité d'avoir un autoto update de la generation de la map 
// On peu aussi le faire en cliquant sur un bouton de l'éditeur
[CustomEditor (typeof(MapGenerator))]
public class MapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        MapGenerator mapGen = (MapGenerator)target;

        if (DrawDefaultInspector())
        {
            if (mapGen.autoUpdate)
            {
                mapGen.GenerateMap();

            }
        }

        //Bouton Generate dans l'UI Unity
        if (GUILayout.Button("Generate"))
        {
            mapGen.GenerateMap();

        }
    }
}
