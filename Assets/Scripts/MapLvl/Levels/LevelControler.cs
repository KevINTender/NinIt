using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3();
        
    }

    public void LoadLevel(int id)
    {
        SceneManager.LoadScene(2);
        PlayerPrefs.SetInt("levelid", id);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}