using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class AddManger : MonoBehaviour
{
    public GameObject addPrefab;
    public GameObject addUI;
    public Transform m_ContentContainer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddPrefab(){
        var slot = Instantiate(addPrefab);
        slot.transform.SetParent(m_ContentContainer, false);
        slot.transform.localScale = new Vector3(1.0f, 1.0f, 0.0f);
    }
    public void AddUI(){
        var ui = Instantiate(addUI);
        ui.transform.SetParent(m_ContentContainer, false);
        ui.transform.localScale = new Vector3(1.0f, 1.0f, 0.0f);
    }
}
