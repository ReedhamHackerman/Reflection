using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Types : MonoBehaviour
{
    string stringAwake;
    void Start()
    {
        System.Type type = Type.GetType(stringAwake);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
