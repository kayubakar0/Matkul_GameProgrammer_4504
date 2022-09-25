﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScrip : MonoBehaviour
{
    public float movespeed;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x > transform.position.x)
        {
            transform.position = new Vector3(transform.position.x + movespeed * Time.deltaTime, transform.position.y);
        } 
        if(player.transform.position.x < transform.position.x)
        {
            transform.position = new Vector3(transform.position.x - movespeed * Time.deltaTime, transform.position.y);
        } 
        if(player.transform.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + movespeed * Time.deltaTime);
        } 
        if(player.transform.position.y < transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - movespeed * Time.deltaTime);
        }
    }
}
