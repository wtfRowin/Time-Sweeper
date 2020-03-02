﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBarrels : MonoBehaviour
{
    public GameObject explossion;
    public GameObject exploded;
    public float wait;

    void Start()
    {
        Explossion();
    }

    void Explossion()
    {
        Destroy(gameObject);

        GameObject particle = Instantiate(explossion, transform.position, Quaternion.identity);

        Destroy(particle, wait);
        
        Instantiate(exploded, transform.position, Quaternion.identity);
    }

}
