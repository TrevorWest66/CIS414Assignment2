// Add a new script called check distance and attach it to the capsules
// and put the navigate method in that with the update then we can avoid a for
// loop within the update loop in this script

using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEditor;

public class Crawler
{
    GameObjSingleton aSingleton = GameObjSingleton.Instance;
 
    public void DrawCircle(int numObjects, int radius, int scale)
    {
        for (int i = 0; i < numObjects; i++)
        {
            float theta = i * 2 * Mathf.PI / numObjects;

            float x = Mathf.Sin(theta) * radius;

            float y = Mathf.Cos(theta) * radius;

            Vector3 aPosition = new Vector3(x * scale, 2, y * scale);

            aSingleton.Vectors.Add(aPosition);

            GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube); //this line draws the cubes

            //rescale the cubes

            wall.transform.localScale = new Vector3(scale, scale, scale);

            wall.transform.position = aPosition;
        }
    }
}
