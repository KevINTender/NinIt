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
    }

    public void LoadScene(int _sceneId)
    {
        StartOnBlindAnimation();
        StartCoroutine(LoadAfterAnim(_sceneId));
    }

    public IEnumerator LoadAfterAnim(int _sceneId)
    {   
        yield return new WaitForSeconds(blindAnim.GetClip("BlindOn").length);
        SceneManager.LoadScene(_sceneId);
    }

    public void StartOnBlindAnimation()
    {
        blindAnim.CrossFade("BlindOn");
    }

    void StartOffBlinAnimation()
    {
        blindAnim.CrossFade("BlindOff");
    }
}
