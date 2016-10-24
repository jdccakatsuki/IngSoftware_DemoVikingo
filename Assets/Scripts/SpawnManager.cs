using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

    //Singleton

    private static SpawnManager instance;
    public static SpawnManager Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    //Class

    void SpawnObject(GameObject target)
    {
        
    }
}