using UnityEngine;
using UnityEngine.UI;

public class kmHesaplama : MonoBehaviour
{
    public static float kmValue = 0;
    Text HP;
    // Start is called before the first frame update
    void Start()
    {
        HP = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        HP.text = "KM : " + System.Math.Round(kmValue, 2);
    }
}
