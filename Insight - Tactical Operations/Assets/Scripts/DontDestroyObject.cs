﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyObject : MonoBehaviour {


    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
