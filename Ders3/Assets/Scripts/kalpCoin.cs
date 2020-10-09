using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kalpCoin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject araba;

    void OnCollisionEnter2D(Collision2D carpisma)

    {
        if (araba.tag == carpisma.gameObject.tag)
        {
            if (Health.hpValue <= 80)
            {
                Health.hpValue = Health.hpValue + 20;
                Destroy(this.gameObject);

            }
            else
            {
                Health.hpValue = 100;
                Destroy(this.gameObject);
            }

        }

    }

    void Start()
    {

        float rast = Random.Range(-1.40f, 1.40f);
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
