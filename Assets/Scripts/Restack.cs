﻿using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Restack : MonoBehaviour
{
    public List<GameObject> Cups;
    public int AmountOfCups;

	// Use this for initialization
	void Start ()
	{

         Cups = new List<GameObject>();
	    foreach (var child in gameObject.GetComponentsInChildren<Cup>())
	    {
	        Cups.Add(child.gameObject);
	    }
    }
	
	// Update is called once per frame
    void Consolidation()
    {
        switch (AmountOfCups)
        {
            case 6:
            {
                foreach (var cup in Cups)
                {
                    
                }
                break;
            }
        }
    }
}
