using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {
	public GameObject bullet;
	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn" ,1f, 2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn(){
		Vector3 pos = new Vector3(Random.Range(-7.7f,6.6f),10f,2.8f);
		Instantiate(bullet,pos,Quaternion.identity);
	}
}
