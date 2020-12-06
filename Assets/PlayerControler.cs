using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public Vector3 goal;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,goal) > 1)
        {
            speed = 15;
        }
        else
        {
            speed = 1;
        }
        transform.position = Vector3.Lerp(transform.position,goal,Time.deltaTime * speed);
    }
    public void SetGoal(Vector3 newGoal)
    {
        goal = newGoal;
    }
}
