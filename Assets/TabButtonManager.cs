using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TabButtonManager : MonoBehaviour
{
    private static TabButtonManager _instance = null;
    public bool innerTabflag = false;
    public static TabButtonManager Instance{
        get{
            if(_instance == null){
                GameObject.FindObjectOfType<TabButtonManager>();
                if(_instance == null){
                    Debug.LogError("There's no active TabButtonManager object");
                }
            }
            return _instance;
        }
    }

    TabButton tabButton;
    void Start()
    {
        InitTabButton();
    }

    private void InitTabButton(){
        for(int childIndex = 0;childIndex < transform.childCount;childIndex++){
            transform.GetChild(childIndex).GetComponent<TabButton>().Deselect();
        }
        if(innerTabflag && transform.childCount != 0 ){
            transform.GetChild(0).GetComponent<TabButton>().Select();
            tabButton = transform.GetChild(0).GetComponent<TabButton>();
        }
    }

    public void SelectedButton(TabButton _button){
        if(!innerTabflag){
            bool flag = false;
            if(tabButton != null){
                tabButton.Deselect();
                if(tabButton == _button){
                    flag = true;
                    tabButton = transform.GetChild(0).GetComponent<TabButton>();
                }
            }
            if(!flag){
                tabButton = _button;
                tabButton.Select();
            }
        }
        else{
            if(tabButton != null){
                tabButton.Deselect();
            }
            tabButton = _button;
            tabButton.Select();
        }
    }
}
