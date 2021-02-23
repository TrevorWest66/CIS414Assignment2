using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

// This class needs to be upated to allow for the strategy pattern with speed as well as being updated to loop through the singleton list rather than 
class Zombie : AbstractObjectCreator
{
    public override GameObject Create()
    {
        GameObjSingleton aSingleton = GameObjSingleton.Instance;

        aSingleton.AddGameObject(GameObject.CreatePrimitive(PrimitiveType.Capsule));

        GameObject xx = aSingleton.GetGameObject(0);

        UnityEngine.AI.NavMeshAgent myNavMeshAgent = xx.AddComponent<UnityEngine.AI.NavMeshAgent>();
        xx.AddComponent<Rigidbody>();
        xx.GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Continuous;

        myNavMeshAgent.speed = 10;
        myNavMeshAgent.angularSpeed = 360;

        return xx;
    }
}
