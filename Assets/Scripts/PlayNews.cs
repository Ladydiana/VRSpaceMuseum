using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class PlayNews : MonoBehaviour {

	public RawImage vidPanelImage;
	public GameObject screen;
	public VideoPlayer vp;
	public VideoClip clip;
	public RawImage vidPanelImage2;
	public GameObject screen2;
	public VideoPlayer vp2;
	public VideoClip clip2;
	public AudioSource audio;
	private RenderTexture text;
	private RenderTexture text2;
	private static bool clicked = false;

	public void Start () {
		screen.SetActive(clicked);
		screen2.SetActive(clicked);
	}

	public void PlayVid () {



		if (!clicked) {
			screen.SetActive (!clicked);
			text = new RenderTexture ((int)vp.clip.width, (int)vp.clip.height, 0);
			vp.targetTexture = text;
			vidPanelImage.texture = text;

			screen2.SetActive (!clicked);
			text2 = new RenderTexture ((int)vp2.clip.width, (int)vp2.clip.height, 0);
			vp2.targetTexture = text2;
			vidPanelImage2.texture = text2;

			//Vector3 scale = vidPanelImage.transform.localScale;

			//vp = vidPanelImage.GetComponent<VideoPlayer> ();
			//vp.clip = clip;
			vp.Play ();
			vp2.Play ();
			audio.Play ();

		} 
		else if(clicked || !vp.isPlaying || !vp2.isPlaying){
			vp.Stop ();
			vp2.Stop ();
			audio.Stop ();
			screen.SetActive (!clicked);
			screen2.SetActive (!clicked);
		}

		clicked = !clicked;

	}


}

