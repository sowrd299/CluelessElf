using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public float spawnTime = 3f;
    public GameObject mEnemy;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
	}
	
    void Spawn()
    {
        GameObject.Instantiate(mEnemy, new Vector2(Random.Range(-45.0f, 45.0f), Random.Range(-45.0f, 45.0f)), Quaternion.identity);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
