using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {
	GameObject[] asteroids; 
	// Use this for initialization
//	GameObject[] spheres; 
	void Start ()
	{

		AsteroidData loadAD = new AsteroidData ("Asteroid.txt");
//		print(loadAD.position);
		
//		print(loadAD.posArray.Length);
		asteroids = new GameObject[loadAD.posArray.Length];		
		for (int i = 0; i < loadAD.posArray.Length; i++) {
			asteroids[i] = Instantiate(Resources.Load ("Prefabs/Sphere") as GameObject);
			asteroids[i].transform.position = loadAD.posArray[i]; 
		}

	}
	
	// Update is called once per frame
	void Update () {
	
		
	}
}
