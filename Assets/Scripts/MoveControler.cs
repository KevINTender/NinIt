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

    public void Start()
    {

    }

    
    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        startMoveV = eventData.pointerCurrentRaycast.worldPosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        endMoveV = eventData.pointerCurrentRaycast.worldPosition;
        Vector3 moveV = endMoveV - startMoveV;
        RaycastHit2D hit = Physics2D.Raycast(playerObj.transform.position, moveV);
        if (hit.collider != null)
        {
            Instantiate(pointPrefab, hit.point, Quaternion.identity);
            playerObj.GetComponent<PlayerControler>().SetGoal(hit.point);
        }
    }
}
