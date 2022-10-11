using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using TMPro;

public class UIHandler : MonoBehaviour
{
    public GameObject ui;
    public GameObject slot;
    public Transform container;


    // 프로토타입까지의 OpenUI는 SetActive(true)와 기능이 같음
    public void OpenUI(){
        ui.SetActive(true);
    }
    // 프로토타입까지의 CloseUI는 SetActive(false)와 기능이 같음
    public void CloseUI(){
        ui.SetActive(false);
    }

    public void AddSlot(){
        var Slot = Instantiate(slot);
        Slot.transform.SetParent(container, false);
        Slot.transform.localScale = new Vector3(1.0f, 1.0f, 0.0f);
    }
    public void DeleteSlot(){

    }
    // GraphPopup용
    public void InstantiateUI(){
        Debug.Log("1");
        var UI = Instantiate(ui);
        UI.transform.SetParent(container, false);
        UI.transform.localScale = new Vector3(1.0f, 1.0f, 0.0f);
    }
    //
    public void DestroyUI(){
        Destroy(this);
    }
    public void ChangeScene(){
        if(SceneManager.GetActiveScene().buildIndex == 0){
            SceneManager.LoadScene(1);
        }
        else if(SceneManager.GetActiveScene().buildIndex == 1){
            SceneManager.LoadScene(0);
        }   
    }
}
