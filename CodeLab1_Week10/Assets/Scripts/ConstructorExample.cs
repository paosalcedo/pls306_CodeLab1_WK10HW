using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructorExample {

	public float temp;
	public string name;
	public GameObject gameObject;
	public int mattParker;
	public bool isCool;
	public Wk10Manager manager;

	//Empty Constructor

	public ConstructorExample (){
	}

	public ConstructorExample(float _temp, string _name){
		temp = _temp;
		name = _name;
	}
}
