using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TabButton : MonoBehaviour
{
    public UnityEvent onTabSelected;
    public UnityEvent onTabDeselected;

    public void Select(){
        if(onTabSelected != null){
            onTabSelected.Invoke();
        }
    }

    public void Deselect(){
        if(onTabDeselected != null){
            onTabDeselected.Invoke();
        }
    }
    public void OnSelectedTab(TabButton button){
        TabButtonManager.Instance.SelectedButton(button);
    }
}
