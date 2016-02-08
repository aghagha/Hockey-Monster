using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyExample : MonoBehaviour {
	public float startingHealth;
	public float health;
	public Text healthText;
	public Slider healthSlider;
	public GameObject monster;
	

	// Use this for initialization
	void Awake(){
		health = 1000f;
		SetHealthText();
		healthSlider.maxValue = health;
		healthSlider.value = health;

	}

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		IsDead();
	}

	void IsDead(){
		if(health <= 0f){
			Destroy(monster);
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "bullets"){
			float damage = col.gameObject.GetComponent<Bullet>().damage;
			float force = col.gameObject.GetComponent<Bullet>().currMag;
			float totalDamage = damage + force;
			print("BAM! You Dealt "+totalDamage+" damage!");
			health -= (totalDamage);
			if(health<0f)health=0f;
			SetHealthText();
			Destroy(col.gameObject);
		}
	}

	void SetHealthText(){
		int hp = (int)health;
		healthText.text = "Enemy : " + hp.ToString();
		healthSlider.value = health;
	}
}
