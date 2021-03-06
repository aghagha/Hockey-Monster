﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Orb : MonoBehaviour {
	
	public float speed = 20f;
    public GameObject barrier;
    public Button barrierButton;

	Rigidbody2D rb;
    public float barrierTimer = 0f;

	void Awake(){
		rb = GetComponent<Rigidbody2D>();
        barrier.GetComponent<Renderer>().enabled = false;
        barrier.GetComponent<Collider2D>().enabled = false;
    }
	
	void Start () {
		
	}

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        BarrierSkill();
    }
	
	void FixedUpdate(){
		Vector3 pos = Input.mousePosition;
		pos.z = 0;
		pos = GetWorldPositionOnPlane(pos,pos.z);
		
		InvisWall(ref pos);
		MoveToFinger(pos);
	}
	
	void InvisWall(ref Vector3 pos){
		if(pos.y > -3f) pos.y = -3f;
	}
	
	void MoveToFinger(Vector3 pos){
		rb.velocity = (pos - transform.position)*speed;
	}
	
	public Vector3 GetWorldPositionOnPlane(Vector3 screenPosition, float z) {
		Ray ray = Camera.main.ScreenPointToRay(screenPosition);
		Plane xy = new Plane(Vector3.forward, new Vector3(0, 0, z));
		float distance;
		xy.Raycast(ray, out distance);
		return ray.GetPoint(distance);
	}

    public void ActivateBarrier()
    {
        barrierTimer = 100f;
    }
	

    void BarrierSkill()
    {
        if (barrierTimer > 0f)
        {
            barrier.GetComponent<Renderer>().enabled = true;
            barrier.GetComponent<Collider2D>().enabled = true;
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), barrier.GetComponent<Collider2D>());
            barrierTimer -= 1f;
        }
        else
        {
            barrier.GetComponent<Renderer>().enabled = false;
            barrier.GetComponent<Collider2D>().enabled = false;
        }
    }
}
