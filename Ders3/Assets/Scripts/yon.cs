using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yon : MonoBehaviour
{
    Rigidbody2D rigi;

    public Sprite Boom;
    public Sprite Turbo;
    public Sprite Normal;
    public Sprite Hasar1;
    public Sprite Hasar2;
    public Sprite Hasar3;
    public Sprite TurboHasar1;
    public Sprite TurboHasar2;
    public Sprite TurboHasar3;
    public Sprite TurboGun;
    public Sprite NormalGun;
    public GameObject patlama;
    public GameObject mermiler;
    public GameObject turboAnimasyon;


    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Health.hpValue >= 80 && turboValue.TurboValue == 0)
        {
            if (bulletValue.BulletValue > 0)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = NormalGun;
            }
            if (bulletValue.BulletValue == 0)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Normal;
            }
        }
        else if (Health.hpValue >= 60 && Health.hpValue < 80 && turboValue.TurboValue == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Hasar1;
        }
        else if (Health.hpValue >= 40 && Health.hpValue < 60 && turboValue.TurboValue == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Hasar2;
        }
        else if (Health.hpValue >= 20 && Health.hpValue < 40 && turboValue.TurboValue == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Hasar3;
        }

        if (Health.hpValue <= 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Boom;
            patlama.SetActive(true);
            turboAnimasyon.SetActive(false);
            Health.hpValue = 0;
            turboValue.TurboValue = 0;
        }

        if (fuel.fuelValue <= 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Boom;
            patlama.SetActive(true);
            turboAnimasyon.SetActive(false);
            fuel.fuelValue = 0;
            turboValue.TurboValue = 0;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            
            if (Health.hpValue > 0 && fuel.fuelValue > 0)
            {
                turboAnimasyon.SetActive(true);
                turboValue.TurboValue = 1;
               
                if (Health.hpValue >= 80)
                {
                    if (bulletValue.BulletValue > 0)
                    {
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = TurboGun;
                    }
                    if (bulletValue.BulletValue == 0)
                    {
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = Turbo;
                    }
                }
                else if (Health.hpValue >= 60 && Health.hpValue < 80)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = TurboHasar1;
                }
                else if (Health.hpValue >= 40 && Health.hpValue < 60)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = TurboHasar2;
                }
                else if (Health.hpValue >= 20 && Health.hpValue < 40)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = TurboHasar3;
                }
                fuel.fuelValue = fuel.fuelValue - 5;
                rigi.velocity = Vector3.up;
            }


        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (Health.hpValue > 0 && fuel.fuelValue > 0)
            {
                turboValue.TurboValue = 0;
                turboAnimasyon.SetActive(false);
                fuel.fuelValue = fuel.fuelValue - 1;
                rigi.velocity = Vector3.down;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if (Health.hpValue > 0 && fuel.fuelValue > 0)
            {
                turboValue.TurboValue = 0;
                if (Health.hpValue > 0 && fuel.fuelValue > 0)
                {
                    fuel.fuelValue = fuel.fuelValue - 1;
                    rigi.velocity = Vector3.up;
                }
                rigi.velocity = Vector3.right;
            }

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            if (Health.hpValue > 0 && fuel.fuelValue > 0)
            {
                turboValue.TurboValue = 0;
                if (Health.hpValue > 0 && fuel.fuelValue > 0)
                {
                    fuel.fuelValue = fuel.fuelValue - 1;
                    rigi.velocity = Vector3.up;
                }
                rigi.velocity = Vector3.left;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space) && Health.hpValue>=80)
        {
            if (Health.hpValue > 0 && fuel.fuelValue > 0)
            {
                if (bulletValue.BulletValue > 0)
                {
                    GameObject mermi = Instantiate(mermiler,gameObject.transform);
                    mermi.transform.position = gameObject.transform.position;
                    bulletValue.BulletValue--;
                }
            }

        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0;
            Debug.Log(Time.timeScale);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            Debug.Log(Time.timeScale);
        }
    }
}
