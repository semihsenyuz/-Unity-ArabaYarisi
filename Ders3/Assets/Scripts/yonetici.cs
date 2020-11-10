using UnityEngine;

public class yonetici : MonoBehaviour
{
    public GameObject cizgi;
    public GameObject kamyon;
    public GameObject sari;
    public GameObject yesil;
    public GameObject evler;
    public GameObject coin;
    public GameObject kalp;
    public GameObject fuel1;
    public GameObject engel;
    public GameObject gunCoin;
    public GameObject ball;
    float EngelX = 12.0f;
    void Start()
    {
        InvokeRepeating("cizgi_ekle", 0.0f, 0.5f);
        InvokeRepeating("kamyon_ekle", 0.0f, 11.0f);
        InvokeRepeating("sari_ekle", 0.0f, 5.0f);
        InvokeRepeating("yesil_ekle", 0.0f, 3.0f);
        InvokeRepeating("ev_ekle", 0.0f, 0.7f);
        InvokeRepeating("coin_ekle", 0.0f, 10.0f);
        InvokeRepeating("kalp_ekle", 0.0f, 10.0f);
        InvokeRepeating("fuel_ekle", 0.0f, 10.0f);
        InvokeRepeating("engel_ekle", 0.0f, EngelX);
        InvokeRepeating("gun_ekle", 0.0f, 15.0f);
        InvokeRepeating("ball_ekle", 0.0f, 20.0f);
    }

    void ball_ekle()
    {
        if (Health.hpValue > 0 && fuel.fuelValue > 0)
        {
            if (score.scoreValue >= 2)
            {
                GameObject ball_ekle = Instantiate(ball);
            }
        }
    }

    void gun_ekle()
    {
        if (Health.hpValue > 0 && fuel.fuelValue > 0)
        {
                GameObject gun_ekle = Instantiate(gunCoin);
        }
    }
    void engel_ekle()
    {
        if (Health.hpValue > 0 && fuel.fuelValue > 0)
        {
            if (score.scoreValue >= 2)
            {   
                EngelX = EngelX/(score.scoreValue / 2);
                GameObject engel_ekle = Instantiate(engel);
            }
        }
        
    }


    void fuel_ekle()
    {
        if (Health.hpValue > 0 && fuel.fuelValue > 0)
        {
            GameObject fuel_ekle = Instantiate(fuel1);
        }
    }

    void cizgi_ekle()
    {
        if (Health.hpValue>0 && fuel.fuelValue > 0)
        {
            kmHesaplama.kmValue = kmHesaplama.kmValue + 0.10f;
          if (turboValue.TurboValue==0)
             {
                fuel.fuelValue--;
                GameObject yeni_cizgi = Instantiate(cizgi);
            }
          if (turboValue.TurboValue == 1)
           {
            fuel.fuelValue=fuel.fuelValue-5;
            GameObject yeni_cizgi = Instantiate(cizgi);
           }
        }
    }

    void coin_ekle()
    {
        if (Health.hpValue > 0 && fuel.fuelValue > 0)
        {
            GameObject coin_ekle = Instantiate(coin);
        }
    }

    void kalp_ekle()
    {
        if (Health.hpValue > 0 && fuel.fuelValue > 0)
        {
            GameObject kalp_ekle = Instantiate(kalp);
        }
    }

    void kamyon_ekle()
    {
        if (Health.hpValue > 0 && fuel.fuelValue > 0)
        {
            GameObject yeni_kamyon = Instantiate(kamyon);
        }
    }
    void sari_ekle()
    {
        if (Health.hpValue > 0 && fuel.fuelValue > 0)
        {
            GameObject yeni_sari = Instantiate(sari);
        }
    }
    void yesil_ekle()
    {
        if (Health.hpValue > 0 && fuel.fuelValue > 0)
        {
            GameObject yeni_yesil = Instantiate(yesil);
        }
    }

    void ev_ekle()
    {
        if (Health.hpValue > 0 && fuel.fuelValue > 0)
        {
            GameObject ev_ekle = Instantiate(evler);
        }
    }

}
