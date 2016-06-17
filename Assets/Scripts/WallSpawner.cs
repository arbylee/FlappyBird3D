using UnityEngine;
using System.Collections;

public class WallSpawner : MonoBehaviour {
	public GameObject wallsPrefab;

	void Start () {
		StartCoroutine (DelayedWallSpawn());
	}
	
	IEnumerator DelayedWallSpawn () {
		while (true) {
			yield return new WaitForSeconds (1.5f);
			SpawnWalls ();
		}
	}

	void SpawnWalls(){
		Vector3 spawnPosition = new Vector3 (0, 0, 30f);
		Instantiate (wallsPrefab, spawnPosition, Quaternion.identity);
	}
}
