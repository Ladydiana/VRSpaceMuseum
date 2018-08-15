using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayScript : MonoBehaviour {

	public AudioSource destructSound;

	private bool reload = false;

	public void reloadScene() {

		destructSound.Play ();
		reload = true;
		/*while (destructSound.isPlaying) {
		}

		SceneManager.LoadScene ("Main");*/
	}

	void Update (){
		if (!destructSound.isPlaying && reload) {
			SceneManager.LoadScene ("Main");
		}
	}
}
