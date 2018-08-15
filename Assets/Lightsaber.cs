using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightsaber : MonoBehaviour {


	LineRenderer lineRend;
	public Transform startPos;
	public Transform endPos;
	public AudioSource igniteSound;
	private float textureOffset = 0;
	private bool on = false;
	private bool oneClick = false;
	private Vector3 extendedPos;
	private float timerClick1, timerClick2;
	private float delay = 0.7f;



	// Use this for initialization
	void Start () {
		lineRend = GetComponent<LineRenderer> ();
		extendedPos = endPos.localPosition;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0)) {

			if (!oneClick) {
				oneClick = !oneClick;
				timerClick1 = Time.time;
			} 
			else {
				oneClick = !oneClick;
				timerClick2 = Time.time;

				if (timerClick2 - timerClick1 <= delay) {
					on = !on;
					igniteSound.Play ();
				} 
				else {
					timerClick1 = timerClick2;
					oneClick = !oneClick;
				}
			}
		}

		if (on) {
			endPos.localPosition = Vector3.Lerp(endPos.localPosition, extendedPos, Time.deltaTime*5f);
	
		} 
		else {
			endPos.localPosition = Vector3.Lerp(endPos.localPosition, startPos.localPosition, Time.deltaTime*5f);
		}

		lineRend.SetPosition (0, startPos.position);
		lineRend.SetPosition (1, endPos.position);

		textureOffset -= Time.deltaTime * 2f;

		if (textureOffset < -10f) {
			textureOffset += 10f;
		}

		lineRend.sharedMaterials [1].SetTextureOffset ("_MainTex", new Vector2 (textureOffset, 0f));
	}
}
