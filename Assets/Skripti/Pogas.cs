using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pogas : MonoBehaviour {

	//Ainu parslegsana ar pogu
	public void saktSpeli() {
		SceneManager.LoadScene ("Pilseta");
	}

	public void restartet() {
		SceneManager.LoadScene ("Menu");
	}
}
