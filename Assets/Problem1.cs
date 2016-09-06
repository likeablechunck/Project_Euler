﻿using UnityEngine;
using System.Collections;

public class Problem1 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        /*
            If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
            The sum of these multiples is 23.

            Find the sum of all the multiples of 3 or 5 below 1000.
        */
        int sum = 0;

        for(int num = 0; num < 1000; ++num)
        {
            if(num % 3 == 0 || num % 5 == 0)
            {
                sum += num;
            }
        }

        Debug.Log("Problem 1 Solution: " + sum);
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}



