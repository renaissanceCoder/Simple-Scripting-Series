using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperRandomSpawner : MonoBehaviour {

	public GameObject[] spawnees;
    public GameObject[] spawnPoints;

    public float radius = 2;

    int randomInt;
    int randomIntTwo;
    Vector3 randomVec;

    void Start() {
        spawnPoints = GameObject.FindGameObjectsWithTag("spawnPoint");
    }
    
    // Update is called once per frame
    void Update () {
        if(Input.GetMouseButton(0)) {
            SpawnRandom();
        }
    }

    int GetRandom(int count) {
        return Random.Range(0, count);
    }

    Vector3 GetRandomVector (Vector3 vec) {
        return (Random.insideUnitSphere * radius) + vec;
    }

    void SpawnRandom() {
        randomInt = GetRandom(spawnees.Length);
        randomIntTwo = GetRandom(spawnPoints.Length);
        randomVec = GetRandomVector(spawnPoints[randomIntTwo].transform.position);
        Instantiate(spawnees[randomInt], randomVec, spawnPoints[randomIntTwo].transform.rotation);
    }
}
