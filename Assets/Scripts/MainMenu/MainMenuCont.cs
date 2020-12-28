using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCont : MonoBehaviour
{
    public void LoadMapLvl(int _MapLvlId)
    {
        SceneManager.LoadScene(_MapLvlId);
    }
}
