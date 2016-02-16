using UnityEngine;
using System.Collections;

public class Orb : MonoBehaviour {
	
	public float speed = 20f;
	Rigidbody2D rb;

	void Awake(){
		rb = GetComponent<Rigidbody2D>();
	}
	
	void Start () {
		
	}

	void Update () {

	}
	
	void FixedUpdate(){
		Vector3 pos = Input.mousePosition;
		pos.z = 0;
		pos = GetWorldPositionOnPlane(pos,pos.z);
		
		InvisWall(ref pos);
		MoveToFinger(pos);
	}
	
	void InvisWall(ref Vector3 pos){
		if(pos.y > -5f) pos.y = -5f;
	}
	
	void MoveToFinger(Vector3 pos){
		rb.velocity = (pos - this.transform.position)*speed;
	}
	
	public Vector3 GetWorldPositionOnPlane(Vector3 screenPosition, float z) {
		Ray ray = Camera.main.ScreenPointToRay(screenPosition);
		Plane xy = new Plane(Vector3.forward, new Vector3(0, 0, z));
		float distance;
		xy.Raycast(ray, out distance);
		return ray.GetPoint(distance);
	}
	
}
