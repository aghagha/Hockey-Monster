using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {
	public GameObject bullet1;
    public GameObject bullet2;
    public GameObject bullet3;

    public float bulletTimer = 1000f;


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        bulletTimer -= 1f;
        if (bulletTimer > 400f)
        {
            if(bulletTimer % 70 == 0)
                AttackTypeOne();
        }
        else if(bulletTimer % 10000 == 0)
        {
            AttackTypeTwo();
            if (bulletTimer <= 0f) bulletTimer = 1000f;
        }
    }

    void AttackTypeOne()
    {
        Vector3 pos = new Vector3(-0.2f, 10f, 2.8f);
        Instantiate(bullet1, pos, Quaternion.identity);
        

    }

    void AttackTypeTwo()
    {
        Vector3 pos = new Vector3(-0.2f, 10f, 2.8f);
        Instantiate(bullet2, pos, Quaternion.identity);
    }
}
