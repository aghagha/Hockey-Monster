using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
    bool isDead = false;

    public float hp;
    public GameObject playerAvatar;
    public Slider healthBar;

	// Use this for initialization

    void Awake()
    {
        hp = 1000f;
        healthBar.maxValue = hp;
        healthBar.value = hp;
    }
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "bullets")
        {
            float damage = col.gameObject.GetComponent<BulletFather>().damage;
            float force = col.gameObject.GetComponent<BulletFather>().currMag;
            float totalDamage = damage + force;
            hp -= totalDamage;
            healthBar.value = hp;
            print("You took " + totalDamage + " damage!");
            Destroy(col.gameObject);
            if(hp <= 0)
            {
                hp = 0;
                healthBar.value = 0;
                Destroy(playerAvatar);
                isDead = true;
            }
        } else
        {
            print("sek salah");
        }
    }
}
