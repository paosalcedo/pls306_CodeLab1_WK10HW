using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wk10Manager : MonoBehaviour {

	ConstructorExample myLoader;

	void Start () {
		myLoader = new ConstructorExample(0.123f, "Hi!");
		myLoader.temp = 0.123f;
		myLoader.manager = this;
 	}
	
	void Update () {
		
	}
}
