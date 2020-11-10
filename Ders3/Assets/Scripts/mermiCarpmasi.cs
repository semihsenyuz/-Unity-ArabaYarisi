using UnityEngine;

public class mermiCarpmasi : MonoBehaviour
{
    public GameObject araba;

    void OnCollisionEnter2D(Collision2D carpisma)

    {
        Destroy(carpisma.gameObject);
        Destroy(gameObject);
    }

    void Start()
    {

        //this.transform.position = new Vector3(araba.transform.localPosition.x, araba.transform.localPosition.y,0);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y >= 6.0f)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector3.up * Time.deltaTime);
        if (Health.hpValue <= 0 || fuel.fuelValue <= 0)

        {
            Destroy(gameObject);
        }
    }
}
