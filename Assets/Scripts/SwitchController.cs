﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{

    public bool isButtonPressed;

    public GameObject Switch1;
    public GameObject Switch2;




    // Start is called before the first frame update
    void Start()
    {
        Switch2.SetActive(false);
    }

    void Interact()
    {
        Debug.Log("Button active!");
            Switch2.SetActive(true);
    }
}
