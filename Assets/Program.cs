using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AI;

public class Program : MonoBehaviour
{
    void Start()
    {
        Crawler crawler = new Crawler();
        GameObjSingleton aSingleton = GameObjSingleton.Instance;
        int NumberOfZombies = 1;

        crawler.DrawCircle(10, 5, 6);
        AbstractObjectCreator ZombieCreator = new Zombie();
        for(int i = 0; i < NumberOfZombies; i++)
        {
            GameObject ZombieUnit = ZombieCreator.Create();
            ZombieUnit.AddComponent<Navigator>();
            ZombieUnit.GetComponent<NavMeshAgent>().SetDestination(aSingleton.Vectors[1]);
        }
    }
}
