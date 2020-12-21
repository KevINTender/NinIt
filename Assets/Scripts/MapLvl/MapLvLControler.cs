using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapLvLControler : MonoBehaviour
{
    [SerializeField]
    private int MapLvlId;


    public void LoadMapLvl()
    {
        SceneManager.LoadScene(MapLvlId);
    }
}
