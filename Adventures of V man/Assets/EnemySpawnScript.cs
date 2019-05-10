using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject enemy;
	float randX;
	Vector2 whereToSpawn;
	public float spawnRate = 2f;
	float nextSpawn = 0.0f;
	
	void Update(){
		if (Time.time > nextSpawn){
			nextSpawn = Time.time + spawnRate;
			randX = Random.Range (-8.4f,100.4f); //range of random spawn
			whereToSpawn = new Vector2 (randX , transform.position.y);
			Instantiate(enemy,whereToSpawn,Quaternion.identity);
		}
		
	}
}
