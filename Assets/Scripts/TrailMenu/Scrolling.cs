using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scrolling : MonoBehaviour
{

    //Прикольная штука, думаю надо почаще пользоваться этим приколом
    [Range(1, 50)]
    [Header("Controllers")]
    public int panCount;
    // Расстояние между обьектами
    [Range(0, 2000)]
    public int panOffset;
    //т.е. начинаем магнитить когда скорость прокрутки ниже этого числа
    //п.ы. непло смотрится в районе 500-700
    [Range(100, 1000)]
    public int minSpeedSpan;
    // скорость примагничивания
    [Range(0f, 20f)]
    public float snapSpeed;
    [Range(0f, 10f)]
    public float scaleOffset;
    // то на сколько увеличивается текущий элемент
    [Range(0f, 2f)]
    public float scaleChange;
    [Range(1f, 20f)]
    public float scaleSpeed;
    [Header("Other Objects")]
    // префаб который спавним уровни/скины и тд. Чтобы был лист разных префабов то надо менять тут
    public GameObject panPrefab;
    public ScrollRect scrollRect;

    private GameObject[] instPans;
    private Vector2[] pansPos;
    private Vector2[] pansScale;

    private RectTransform contentRect;
    private Vector2 contentVector;

    private int selectedPanID;
    private bool isScrolling;

    private void Start()
    {
        contentRect = GetComponent<RectTransform>();
        instPans = new GameObject[panCount];
        pansPos = new Vector2[panCount];
        pansScale = new Vector2[panCount];
        for (int i = 0; i < panCount; i++)
        {
            instPans[i] = Instantiate(panPrefab, transform, false);
            if (i == 0) continue;
            instPans[i].transform.localPosition = new Vector2(instPans[i - 1].transform.localPosition.x +
                                                  panPrefab.GetComponent<RectTransform>().sizeDelta.x + panOffset,
                                                  instPans[i].transform.localPosition.y);
            pansPos[i] = -instPans[i].transform.localPosition;
        }
    }

    private void FixedUpdate()
    {
        if (contentRect.anchoredPosition.x >= pansPos[0].x && !isScrolling || contentRect.anchoredPosition.x <= pansPos[pansPos.Length - 1].x && !isScrolling)
            scrollRect.inertia = false;
        float nearestPos = float.MaxValue;
        for (int i = 0; i < panCount; i++)
        {
            float distance = Mathf.Abs(contentRect.anchoredPosition.x - pansPos[i].x);
            if (distance < nearestPos)
            {
                nearestPos = distance;
                selectedPanID = i;
            }
            float scale = Mathf.Clamp(1 / (distance / panOffset) * scaleOffset, 0.5f, 1f);
            pansScale[i].x = Mathf.SmoothStep(instPans[i].transform.localScale.x, scale + scaleChange, scaleSpeed * Time.fixedDeltaTime);
            pansScale[i].y = Mathf.SmoothStep(instPans[i].transform.localScale.y, scale + scaleChange, scaleSpeed * Time.fixedDeltaTime);
            instPans[i].transform.localScale = pansScale[i];
        }
        float scrollVelocity = Mathf.Abs(scrollRect.velocity.x);
        if (scrollVelocity < minSpeedSpan && !isScrolling) scrollRect.inertia = false;
        if (isScrolling || scrollVelocity > minSpeedSpan) return;
        contentVector.x = Mathf.SmoothStep(contentRect.anchoredPosition.x, pansPos[selectedPanID].x, snapSpeed * Time.fixedDeltaTime);
        contentRect.anchoredPosition = contentVector;
    }

    public void Scrollin(bool scroll)
    {
        isScrolling = scroll;
        if (scroll) scrollRect.inertia = true;
    }
}
