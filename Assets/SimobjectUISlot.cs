using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class SimobjectUISlot : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler
{
    public GameObject dragObject;
    public Image imageSimobject;
    public GameObject simobjectUI;

    public void OnBeginDrag(PointerEventData eventData){
        /*
        DragSlot.instance.dragSlot = this;
        DragSlot.instance.DragSetImage(imageSimobject);
        DragSlot.instance.transform.position = eventData.position;
        Debug.Log("Start Drag Slot position: " +  DragSlot.instance.transform.position);
        */
    }
    public void OnDrag(PointerEventData eventData){
        /*
        DragSlot.instance.transform.position = eventData.position;
        Debug.Log("On Drag position: " + DragSlot.instance.transform.position);
        */
    }

    public void OnEndDrag(PointerEventData eventData){
        /*DragSlot.instance.SetColor(0);
        DragSlot.instance.dragSlot = null;
        Destroy(dragObject);
        */
    }
    public void OnDrop(PointerEventData eventData){

    }
    public void DeleteSimobjectUISlot(){
        Destroy(this.gameObject);
    }
    public void OpenSimobjectUI(){
        simobjectUI.SetActive(true);
    }
}
