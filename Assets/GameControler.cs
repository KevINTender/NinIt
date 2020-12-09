using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    public GameObject boxSet;
    public Transform setSpawn;
    void Start()
    {
        
    }
    
    void StartGame()
    {
        InstantiateObstacles();
        InstantiateCharacter();
    }

    void RestartCicle()
    {
        SetCharacterOnStartPostion();
        InstantiateObstacles();
    }

    void InstantiateObstacles()
    {
        void GetPostionOfInstantiate()
        {

        }
        void InstantiateOnPositions()
        {

        }
    }

    void InstantiateCharacter()
    {

    }

    void MoveCharacter()
    {
        void move()
        {

        }
        void fastmove()
        {

        }
        void destroy()
        {

        }
    }

    void DestroyObstacle()
    {

    }

    void SetCharacterOnStartPostion()
    {

    }

    void InstantiateSate()
    {
        Instantiate(boxSet, setSpawn);
    }
}
