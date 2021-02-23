using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class GameObjSingleton
{
    private List<GameObject> gameObjectList = new List<GameObject>();
    public List<Vector3> Vectors { get; set; }

    private readonly static GameObjSingleton instance;

    //Add a private constructor

    private GameObjSingleton()
    {
        Vectors = new List<Vector3>();
    }
 
    //static constructor which is a lazy constructor which means it will only run the code when it is absolutely needed!!

     static GameObjSingleton()
    {
        GameObjSingleton.instance = new GameObjSingleton();
    }
 
    public static GameObjSingleton Instance
    {
        get
        {
            //use this keyword when dealing with a single object

            //this variable below is attached to the classname

            return GameObjSingleton.instance;
        }
    }
 
    //Method to Add to the List

     public void AddGameObject(GameObject anObj)
    {
        gameObjectList.Add(anObj);
    }
 
    public GameObject GetGameObject(int location)
    {
        return gameObjectList[location];
    }
 
    public int Length()
    {
        return gameObjectList.Count;
    }
}