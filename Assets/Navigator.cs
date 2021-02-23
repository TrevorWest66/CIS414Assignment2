using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AI;

// This class needs to be updated to use the strategy pattern to set hte speed
public class Navigator : MonoBehaviour
{
    GameObjSingleton aSingleton = GameObjSingleton.Instance;

    void Update()
    {
        NavMeshAgent myNavMeshAgent = this.GetComponent<NavMeshAgent>();
        Vector3 ZombieDestination = this.GetComponent<NavMeshAgent>().destination;
        Vector3 CurrentLocation = this.GetComponent<Transform>().position;
        System.Random dest = new System.Random();

        double Distance = Math.Pow(Math.Pow((ZombieDestination.x - CurrentLocation.x), 2) + Math.Pow((ZombieDestination.y - CurrentLocation.y), 2), .5);

        if (Distance <= 3.8)
        {
            // I can't remember if this .Next includes the last number or goes up to the last number so we need to do that too
            myNavMeshAgent.SetDestination(aSingleton.Vectors[dest.Next(0, 9)]);
            //myNavMeshAgent.speed = Mover.Move(myNavMeshAgent.speed);
        }
    }
}
