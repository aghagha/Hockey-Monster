using UnityEngine;
using System.Collections;

public class MonsterOneLightBullet : BulletFather {

	// Use this for initialization
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        damage = 100f;
        maxVelocity = 100f;
        life = 100f;
    }

	void Start () {
        SpawnBullet();
	}

    // Update is called once per frame
    void Update()
    {

    }

	void FixedUpdate () {
        LimitVelocity();
        currMag = rb.velocity.magnitude;
	}

    public override void SpawnBullet()
    {
        force = new Vector2(-100f, -500f);
        rb.AddForce(force * Time.deltaTime, ForceMode2D.Impulse);
        
        force = new Vector2(0, -500f);
        rb.AddForce(force * Time.deltaTime, ForceMode2D.Impulse);

        force = new Vector2(100f, -500f);
        rb.AddForce(force * Time.deltaTime, ForceMode2D.Impulse);
    }
}
