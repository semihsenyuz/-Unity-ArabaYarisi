using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0.03854132f, 5.9f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -6.2f)
        {
            Destroy(gameObject);
        }
        if (Health.hpValue > 0 && fuel.fuelValue > 0)
        {
            transform.Translate(0, -0.7f * Time.deltaTime, 0);
        }
    }
}
