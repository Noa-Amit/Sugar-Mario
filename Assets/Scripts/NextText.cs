using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEngine.Events;

public class NextText : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{


    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("hey");
      //  MyOwnEventTriggered();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnPointerUp(PointerEventData eventData)
    {
    }


    //my event
    [Serializable]
    public class MyOwnEvent : UnityEvent { }

    [SerializeField]
    private MyOwnEvent myOwnEvent = new MyOwnEvent();
    public MyOwnEvent onMyOwnEvent { get { return myOwnEvent; } set { myOwnEvent = value; } }

    public void MyOwnEventTriggered()
    {
        onMyOwnEvent.Invoke();
    }
}
