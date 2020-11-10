using UnityEngine;
using UnityEngine.UI;

public class bulletValue : MonoBehaviour
{
    public static int BulletValue = 1;
    Text bullet;
    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        bullet.text = "Bullet : " + BulletValue;
    }
}
