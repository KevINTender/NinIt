using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInfo : MonoBehaviour
{
    [SerializeField] StartGame startGamecs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        startGamecs.GetEnterPoint();
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        startGamecs.GetEndPoint();
    }
}
