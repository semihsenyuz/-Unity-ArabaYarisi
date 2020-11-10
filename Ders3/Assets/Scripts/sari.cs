using UnityEngine;

public class sari : MonoBehaviour
{
    public GameObject araba;
    public GameObject patlama;

    void OnCollisionEnter2D(Collision2D carpisma)

    {
        if (araba.tag == carpisma.gameObject.tag)
        {
            Health.hpValue = Health.hpValue - 10;
            Destroy(this.gameObject);
            patlama.SetActive(true);

        }
    }

        void Start()
    {

        float rast = Random.Range(-1.10f, 4.20f);
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
