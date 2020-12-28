using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    float speed;
    void Start()
    {
        
    }


    void Update()
    {
        Vector2 buff = transform.position + new Vector3(speed, 0, 0);
        transform.position = Vector2.MoveTowards(transform.position, buff, Time.deltaTime * -speed);
    }
}
