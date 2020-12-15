using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartGame : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] GameObject sliceButton;
    [SerializeField] GameObject touch;
    Vector3 enterPoint;
    Vector3 endPoint;
    float AB;
    float BC;
    float sinA;
    float A;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void GetEnterPoint()
    {
        enterPoint = touch.transform.position;
        /*AB = 1.82f;
        BC = enterPoint.y;      
        sinA = BC / AB;
        A = (sinA * 180) / math.PI;
        Debug.Log(A);*/       
    }

    public void GetEndPoint()
    {
        endPoint = touch.transform.position;
        float buff = Vector2.Distance(enterPoint, endPoint);
        sliceButton.transform.LookAt(endPoint);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 buff = Camera.main.ScreenToWorldPoint(eventData.position) + new Vector3(0, 0, 10);
        touch.transform.position = buff;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        touch.GetComponent<TrailRenderer>().enabled = false;
        touch.GetComponent<TrailRenderer>().enabled = true;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        
    }


}
