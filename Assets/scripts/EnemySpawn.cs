using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawn:MonoBehaviour{
	public float delaytime;
	public GameObject enemyPrefab;
	//public int numberOfEnemies;
	private float next;
	//public float total;
	public bool win;




	void Update(){
		//Debug.Log ("update"+total);
		if (win==false) {
			//Debug.Log ("Can Add more");
			if (Time.time > next) {
				next = Time.time + delaytime;
				float rand = Random.Range (1, 4);
				var spawnRotation = Quaternion.Euler (0f, 0f, 0f);

				//Debug.Log (rand);
				if (rand == 1f) {
					//Debug.Log ("rand==1");
					Vector2 spawnPosition1 = GameObject.FindGameObjectWithTag("Wall1").transform.position;
					var enemy = (GameObject)Instantiate (enemyPrefab, spawnPosition1, spawnRotation);
				} else if (rand == 2f) {
					//Debug.Log ("rand==2");
					Vector2 spawnPosition2 = GameObject.FindGameObjectWithTag("Wall2").transform.position;
					var enemy = (GameObject)Instantiate (enemyPrefab, spawnPosition2, spawnRotation);
				} else {
				//	Debug.Log ("rand==2");
					Vector2 spawnPosition3 = GameObject.FindGameObjectWithTag("Wall3").transform.position;
					var enemy = (GameObject)Instantiate (enemyPrefab, spawnPosition3, spawnRotation);
				}



				//var enemy = (GameObject)Instantiate (enemyPrefab, spawnPosition, spawnRotation);
				//total++;
				//Debug.Log ("update"+total);
			}
		}
	}


			

	

}
