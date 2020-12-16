using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveControler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject pointPrefab;
    public GameObject playerObj;
    Vector3 startMoveV;
    Vector3 endMoveV;
    public bool canMove;  

    public void Start()
    {
        canMove = false;
    }

    
    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (canMove)
        { 
            startMoveV = eventData.pointerCurrentRaycast.worldPosition;
            Debug.Log("START: " + startMoveV);
            //Instantiate(pointPrefab, startMoveV, Quaternion.identity);
        }

    }
    public void OnEndDrag(PointerEventData eventData)
    {
        if (canMove)
        {
            endMoveV = eventData.pointerCurrentRaycast.worldPosition;
            Debug.Log("END: " + endMoveV);
            //Instantiate(pointPrefab, endMoveV, Quaternion.identity);
            Vector3 moveV = endMoveV - startMoveV;
            RaycastHit2D hit = Physics2D.Raycast(playerObj.transform.position, moveV);
            if (hit.collider != null)
            {
                Instantiate(pointPrefab, hit.point, Quaternion.identity);
                playerObj.GetComponent<PlayerControler>().SetGoal(hit.point);
            }
        }
    }
}
