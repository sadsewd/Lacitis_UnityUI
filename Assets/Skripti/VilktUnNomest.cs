using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VilktUnNomest : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public Canvas kanva;
    private RectTransform transformacijulogs;

    private void Awake()
    {
        transformacijulogs = GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData notikums)
    {
        Debug.Log("Iesakts vilkt objektu");
    }
    public void OnDrag(PointerEventData notikums)
    {
        Debug.Log("Tiek vilkts objekts");
        transformacijulogs.anchoredPosition += notikums.delta / kanva.scaleFactor; 
    }
    public void OnEndDrag(PointerEventData notikums)
    {
        Debug.Log("Objekta vilkšana ir pabeigta");
    }
    public void OnPointerDown(PointerEventData notikums)
    {
        Debug.Log("Uz ojekta tika nospieta pele");
    }
}
