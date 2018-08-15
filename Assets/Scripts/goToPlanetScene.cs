using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToPlanetScene : MonoBehaviour {

	public string planetName = "Main";


	public void loadPlanet()
	{
		SceneManager.LoadScene(planetName);
	}


}
