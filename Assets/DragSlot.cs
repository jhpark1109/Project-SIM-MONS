using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragSlot : MonoBehaviour
{
    static public DragSlot instance;
    //public SimobjectSlot dragSlot;

    public Image imageSimobject;

    void Start()
    {
        instance = this;
    }

    public void DragSetImage(Image _imageSimobject){
        imageSimobject.sprite = _imageSimobject.sprite;
        SetColor(1);
    }
    public void SetColor(float _alpha){
        Color color = imageSimobject.color;
        color.a = _alpha;
        imageSimobject.color = color;
    }
}
