using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour {

	public GameObject randomObject;
	public float spawnInterval;
	public float lastSpawn;
	public float moveSpeed;
	public float moveDistance;

	// Update is called once per frame
	void Update () {
		if (Time.time > lastSpawn + spawnInterval) {
			GameObject randObj = (GameObject) Instantiate(randomObject, transform.position, Quaternion.identity);
			GameObject.Destroy(randObj, 10);

			lastSpawn = Time.time;
		}
	
		transform.position = new Vector3(Mathf.Sin(Time.time * moveSpeed) * moveDistance, 6, 0);

		if (Time.time > 15) {
			spawnInterval = 0;
		}
	}

}
