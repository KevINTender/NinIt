using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlindSysCont : MonoBehaviour
{
    // Start is called before the first frame update
    public Animation blindAnim;
    void Start()
    {
        StartOffBlinAnimation();
        Debug.Log("yes i am");
    }
    private void OnLevelWasLoaded(int level)
    {
        
    }

    public void LoadScene(int level)
    {
        SceneManager.LoadScene(level);
    }
    // Update is called once per frame
    public void StartOnBlindAnimation()
    {
        blindAnim.CrossFade("BlindOn");
    }
    void StartOffBlinAnimation()
    {
        blindAnim.CrossFade("BlindOff");
    }
}
