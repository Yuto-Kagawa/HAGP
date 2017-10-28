﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Player;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(Player.transform.position.x, 0, -10);

        if (transform.position.x < 0)
        {
            transform.position = new Vector3(0, 0, -10);
        }

        if (transform.position.x >= 18)
        {
            transform.position = new Vector3(18, 0, -10);
        }
    }
}
