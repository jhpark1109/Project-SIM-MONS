using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject addPrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddPrefab(){
        Instantiate(addPrefab);
    }
}
