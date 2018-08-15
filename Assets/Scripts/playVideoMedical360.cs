using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class playVideoMedical360 : MonoBehaviour {

	public RawImage vidPanelImage;
	public GameObject screen;
	public VideoPlayer vp;
	public VideoClip clip;
	public AudioSource audio;
	private RenderTexture text;
	private static bool clicked = false;

	public void Start () {
		screen.SetActive(clicked);
	}

	public void PlayVid () {



		if (!clicked) {
			screen.SetActive (!clicked);
			text = new RenderTexture ((int)vp.clip.width, (int)vp.clip.height, 0);
			vp.targetTexture = text;
			vidPanelImage.texture = text;

			//Vector3 scale = vidPanelImage.transform.localScale;

			//vp = vidPanelImage.GetComponent<VideoPlayer> ();
			//vp.clip = clip;
			vp.Play ();
			audio.Play ();

		} 
		else if(clicked || !vp.isPlaying){
			vp.Stop ();
			audio.Stop ();
			screen.SetActive (!clicked);
		}

		clicked = !clicked;
		
	}


}
