using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelConScene : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> listLevel = new List<GameObject>();
    
    void Start()
    {
        int id =  PlayerPrefs.GetInt("levelid");
        Instantiate(listLevel[id - 1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
