﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour {
    public bool isCorrect;

    void OnMouseDown()
    {
        if (isCorrect)
        {
            GetComponent<TextMesh>().color = Color.green;
        }
        else
        {
            GetComponent<TextMesh>().color = Color.red;

        }

    }

    void Start () {
        
    }
	
	void Update () {
		
	}
}
