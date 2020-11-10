using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yonetim : MonoBehaviour
{
    public Button rightButton;
    public Button leftButton;
    public Button fireButton;
    public Button upButton;
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

    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
        Button right = rightButton.GetComponent<Button>();
        right.onClick.AddListener(TaskOnClick1);

        Button left = leftButton.GetComponent<Button>();
        left.onClick.AddListener(TaskOnClick2);

        Button fire = fireButton.GetComponent<Button>();
        fire.onClick.AddListener(TaskOnClick3);

        Button up = upButton.GetComponent<Button>();
        up.onClick.AddListener(TaskOnClick4);
    }
    void TaskOnClick1()
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
    void TaskOnClick2()
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
    void TaskOnClick3()
    {
        if (Health.hpValue > 0 && fuel.fuelValue > 0)
        {
            if (bulletValue.BulletValue > 0)
            {
                GameObject mermi = Instantiate(mermiler, gameObject.transform);
                mermi.transform.position = gameObject.transform.position;
                bulletValue.BulletValue--;
            }
        }
    }
    void TaskOnClick4()
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
}

