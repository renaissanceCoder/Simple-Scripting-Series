using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour {

	public GameObject[] spawnees;
	public Transform spawnPos;

	int randomInt;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0)) {
			SpawnRandom();
		}
	}

	void SpawnRandom() {
		randomInt = Random.Range(0, spawnees.Length);
		Instantiate(spawnees[randomInt], spawnPos.position, spawnPos.rotation);
	}
}