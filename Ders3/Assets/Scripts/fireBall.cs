﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBall : MonoBehaviour
{
    public GameObject araba;
    float rast = 0.0f;
    void OnCollisionEnter2D(Collision2D carpisma)

    {
        if (araba.tag == carpisma.gameObject.tag)
        {
            Health.hpValue = Health.hpValue - 50;
            Destroy(this.gameObject);

        }
    }


    // Start is called before the first frame update
    void Start()
    {
        rast = Random.Range(-1.40f, 1.40f);
        transform.position = new Vector3(rast, 5.95f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -6.0f)
        {
            Destroy(gameObject);
        }

        transform.Translate(0, -0.7f * Time.deltaTime, 0);
        if (Health.hpValue <= 0 || fuel.fuelValue <= 0)
        {
            Destroy(gameObject);
        }
    }
}
