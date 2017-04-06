using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {



		//public Vector2 speed = new Vector2(10, 10);

		
		private Transform p1;//=GameObject.FindGameObjectWithTag("PA");
		private Transform p2;
		private Vector2 movement;
		private Rigidbody2D rigidbodyComponent;
		public float speed=7;
		private Transform xx;
	private Vector2 dir;

	public Vector2 direction;
	void Start(){
		if (Random.Range (0, 2) == 1) {
			GameObject es = (GameObject.FindGameObjectWithTag ("PA"));//.GetComponent<EnemySpawn>;
			xx=es.GetComponent<Transform>();

		} else {
			GameObject es = (GameObject.FindGameObjectWithTag ("PB"));//.GetComponent<EnemySpawn>;
			xx=es.GetComponent<Transform>();
		}
		dir = (xx.position - transform.position);
	}
		void Update()
	{
	//	movement = (xx.position - transform.position).normalized * speed;
		//movement.Set (movement.x * 10, movement.y * 10);
		movement = new Vector2(
			speed * dir.x,
			speed* dir.y);
	}

		void FixedUpdate()
		{
			if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();

		rigidbodyComponent.velocity = movement;
		}
	void OnBecameInvisible(){
		Debug.Log ("invisible");

		Destroy (gameObject);
	}

}
