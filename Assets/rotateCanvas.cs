using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCanvas : MonoBehaviour {

	public GameObject canv;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		canv.transform.Rotate(0,20*Time.deltaTime,0);
	}
}
