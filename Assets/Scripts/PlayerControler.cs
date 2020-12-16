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
        if(Vector3.Distance(transform.position, goal - (goal).normalized / 2) > 1)
        {
            speed = 15;
        }
        else
        {
            speed = 10;
        }
        if(Vector3.Distance(transform.position, goal - (goal).normalized / 2) < 0.1f)
        {
            transform.position = goal - (goal).normalized / 2;
        }
        transform.position = Vector3.Lerp(transform.position,goal-(goal).normalized/2,Time.deltaTime * speed);
    }
    public void SetGoal(Vector3 newGoal)
    {
        goal = newGoal;
    }
}
