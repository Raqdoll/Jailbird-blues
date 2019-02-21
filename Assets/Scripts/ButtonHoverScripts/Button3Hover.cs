﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button3Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject cardDisplay;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        cardDisplay.GetComponent<CardDisplay>().button3Hover = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        cardDisplay.GetComponent<CardDisplay>().button3Hover = false;
    }
}
