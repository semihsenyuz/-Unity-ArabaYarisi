using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evler : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(-0.623f, 6.094f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y <= -6.0f)
        {
            Destroy(gameObject);
        }
        if (Health.hpValue > 0 && fuel.fuelValue > 0)
        {
            transform.Translate(0, -0.7f * Time.deltaTime, 0);
        }
    }
}
