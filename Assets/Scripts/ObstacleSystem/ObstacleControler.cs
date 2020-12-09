using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleControler : MonoBehaviour
{
    [SerializeField]
    private GameObject obstaclePb;
    [SerializeField]
    private List<string> obstacleStatus = new List<string>(); // уничтожен, потерян, живой


    void InstantiateObstacle()
    {

    }


    void ChangeObstacleStatus(int id, string newStatus)
    {
        obstacleStatus[id] = newStatus;
    }

    // проверка статусов припятсвий, прошли ли все, уничто же ны ли или нет
    void CheckAllStatus()
    {
        if(obstacleStatus.Exists(x => x == "живой"))
        {
            Debug.Log("Есть живой");
        }
        else
        {
            Debug.Log("Нет живых");
        }
    }
}
