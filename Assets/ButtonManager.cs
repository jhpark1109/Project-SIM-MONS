using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Vector3 defaultScale;
    public Transform buttonScale;
    public GameObject TempUI;
    private void Start(){
        defaultScale = buttonScale.localScale;
    }

    public void OnBtnClick(){

    }
    public void OnPointerEnter(PointerEventData eventData){
        TempUI.SetActive(true);
        buttonScale.localScale = defaultScale * 1.2f;
    }
    public void OnPointerExit(PointerEventData eventData){
        TempUI.SetActive(false);
        buttonScale.localScale = defaultScale;
    }
}
