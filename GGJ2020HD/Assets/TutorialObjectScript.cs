﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialObjectScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Destroy(gameObject);
        }
        if (Input.GetMouseButton(1))
        {
            Destroy(gameObject);
        }
    }
}
