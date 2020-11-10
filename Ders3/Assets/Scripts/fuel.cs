using UnityEngine;
using UnityEngine.UI;

public class fuel : MonoBehaviour
{
    public static int fuelValue = 350;
    Text FUEL;
    // Start is called before the first frame update
    void Start()
    {
        FUEL = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        FUEL.text = "Fuel : " + fuelValue;
    }
}

