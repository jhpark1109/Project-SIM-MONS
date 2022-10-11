using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class PopupManager : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{
    public GameObject thisUI;

    public void OnBeginDrag(PointerEventData eventData){
    
    }
    public void OnDrag(PointerEventData eventData){
        //thisUI.transform.position = eventData.position;
        thisUI.transform.position += (Vector3)(eventData.delta) * 0.01f;//임시방편
    }

    public void OnEndDrag(PointerEventData eventData){
        
    }
    public void OnDrop(PointerEventData eventData){

    }
}
