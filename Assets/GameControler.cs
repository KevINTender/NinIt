using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    public GameObject boxSet;
    public Transform setSpawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void InstantiateSate()
    {
        Instantiate(boxSet, setSpawn);
    }
}
