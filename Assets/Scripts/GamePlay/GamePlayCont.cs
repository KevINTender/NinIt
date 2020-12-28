using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayCont : MonoBehaviour
{
    [SerializeField]
    private int MainMenuId;

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(MainMenuId);
    }
}
