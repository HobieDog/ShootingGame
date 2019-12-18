﻿using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickBtn : MonoBehaviour,IPointerDownHandler, IPointerUpHandler
{

    [HideInInspector]
    public bool pressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
    }
}
