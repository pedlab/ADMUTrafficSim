﻿using UnityEngine;
using System.Collections;

public class TrafficSimulator : MonoBehaviour {

	int spawns;
	public float minSpawnTimer = 1f;
	public float maxSpawnTimer = 2f;

	// Use this for initialization
	void Start () {
		spawns = 0;
		StartCoroutine (Spawner ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int GetScore() {
		long total = 0;
		foreach (GameObject road in GameObject.FindGameObjectsWithTag ("road")) {
			
		}
		return spawns - GameObject.FindGameObjectsWithTag ("car").Length;
	}

	IEnumerator Spawner() {
		while (true) {
			var x = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<CarSpawner>();
			if (Random.value < 0.5f)
				x.SpawnNorth ();
			else
				x.SpawnWest ();
			yield return new WaitForSeconds(Random.Range (minSpawnTimer, maxSpawnTimer));
		}
	}
}
