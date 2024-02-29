using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{

	// References to trophies game objects to control
	public GameObject reward1IDBIG, reward2IDBIG, reward3IDBIG, reward4IDBIG, reward5IDBIG,
	reward1IDBIL, reward2IDBIL, reward3IDBIL, reward4IDBIL, reward5IDBIL,
	reward1IZHHAR, reward2IZHHAR, reward3IZHHAR, reward4IZHHAR, reward5IZHHAR,
	reward1IKHFA, reward2IKHFA, reward3IKHFA, reward4IKHFA, reward5IKHFA,
	reward1IQLAB, reward2IQLAB, reward3IQLAB, reward4IQLAB; //reward5IQLAB;

	// Variables to contain Player Prefs values
	int reward1IDBIGGot, reward2IDBIGGot, reward3IDBIGGot, reward4IDBIGGot, reward5IDBIGGot,
	reward1IDBILGot, reward2IDBILGot, reward3IDBILGot, reward4IDBILGot, reward5IDBILGot,
	reward1IZHHARGot, reward2IZHHARGot, reward3IZHHARGot, reward4IZHHARGot, reward5IZHHARGot,
	reward1IKHFAGot, reward2IKHFAGot, reward3IKHFAGot, reward4IKHFAGot, reward5IKHFAGot,
	reward1IQLABGot, reward2IQLABGot, reward3IQLABGot, reward4IQLABGot; // reward5IQLABGot;

	// Use this for initialization
	void Start () {

		// Getting Player Prefs values to make sure you got
		// particular trophy
		reward1IDBIGGot = PlayerPrefs.GetInt ("Reward1IDBIGGot");
		reward2IDBIGGot = PlayerPrefs.GetInt ("Reward2IDBIGGot");
		reward3IDBIGGot = PlayerPrefs.GetInt ("Reward3IDBIGGot");
		reward4IDBIGGot = PlayerPrefs.GetInt ("Reward4IDBIGGot");
		reward5IDBIGGot = PlayerPrefs.GetInt ("Reward5IDBIGGot");

		reward1IDBILGot = PlayerPrefs.GetInt ("Reward1IDBILGot");
		reward2IDBILGot = PlayerPrefs.GetInt ("Reward2IDBILGot");
		reward3IDBILGot = PlayerPrefs.GetInt ("Reward3IDBILGot");
		reward4IDBILGot = PlayerPrefs.GetInt ("Reward4IDBILGot");
		reward5IDBILGot = PlayerPrefs.GetInt ("Reward5IDBILGot");

		reward1IZHHARGot = PlayerPrefs.GetInt ("Reward1IZHHARGot");
		reward2IZHHARGot = PlayerPrefs.GetInt ("Reward2IZHHARGot");
		reward3IZHHARGot = PlayerPrefs.GetInt ("Reward3IZHHARGot");
		reward4IZHHARGot = PlayerPrefs.GetInt ("Reward4IZHHARGot");
		reward5IZHHARGot = PlayerPrefs.GetInt ("Reward5IZHHARGot");

		reward1IKHFAGot = PlayerPrefs.GetInt ("Reward1IKHFAGot");
		reward2IKHFAGot = PlayerPrefs.GetInt ("Reward2IKHFAGot");
		reward3IKHFAGot = PlayerPrefs.GetInt ("Reward3IKHFAGot");
		reward4IKHFAGot = PlayerPrefs.GetInt ("Reward4IKHFAGot");
		reward5IKHFAGot = PlayerPrefs.GetInt ("Reward5IKHFAGot");

		reward1IQLABGot = PlayerPrefs.GetInt ("Reward1IQLABGot");
		reward2IQLABGot = PlayerPrefs.GetInt ("Reward2IQLABGot");
		reward3IQLABGot = PlayerPrefs.GetInt ("Reward3IQLABGot");
		reward4IQLABGot = PlayerPrefs.GetInt ("Reward4IQLABGot");
		//reward5IQLABGot = PlayerPrefs.GetInt ("Reward5IQLABGot");
		
		
		if (reward1IDBIGGot == 1)			
			reward1IDBIG.SetActive (true);
		else			
			reward1IDBIG.SetActive (false);
		
		if (reward2IDBIGGot == 1)
			reward2IDBIG.SetActive (true);
		else
			reward2IDBIG.SetActive (false);
		
		if (reward3IDBIGGot == 1)
			reward3IDBIG.SetActive (true);
		else
			reward3IDBIG.SetActive (false);

		if (reward4IDBIGGot == 1)
			reward4IDBIG.SetActive (true);
		else
			reward4IDBIG.SetActive (false);
		
		if (reward5IDBIGGot == 1)
			reward5IDBIG.SetActive (true);
		else
			reward5IDBIG.SetActive (false);

		//bates

		if (reward1IDBILGot == 1)			
			reward1IDBIL.SetActive (true);
		else			
			reward1IDBIL.SetActive (false);
		
		if (reward2IDBILGot == 1)
			reward2IDBIL.SetActive (true);
		else
			reward2IDBIL.SetActive (false);
		
		if (reward3IDBILGot == 1)
			reward3IDBIL.SetActive (true);
		else
			reward3IDBIL.SetActive (false);

		if (reward4IDBILGot == 1)
			reward4IDBIL.SetActive (true);
		else
			reward4IDBIL.SetActive (false);
		
		if (reward5IDBILGot == 1)
			reward5IDBIL.SetActive (true);
		else
			reward5IDBIL.SetActive (false);

			//bates

		if (reward1IZHHARGot == 1)			
			reward1IZHHAR.SetActive (true);
		else			
			reward1IZHHAR.SetActive (false);
		
		if (reward2IZHHARGot == 1)
			reward2IZHHAR.SetActive (true);
		else
			reward2IZHHAR.SetActive (false);
		
		if (reward3IZHHARGot == 1)
			reward3IZHHAR.SetActive (true);
		else
			reward3IZHHAR.SetActive (false);

		if (reward4IZHHARGot == 1)
			reward4IZHHAR.SetActive (true);
		else
			reward4IZHHAR.SetActive (false);
		
		if (reward5IZHHARGot == 1)
			reward5IZHHAR.SetActive (true);
		else
			reward5IZHHAR.SetActive (false);

		//bates

		if (reward1IKHFAGot == 1)			
			reward1IKHFA.SetActive (true);
		else			
			reward1IKHFA.SetActive (false);
		
		if (reward2IKHFAGot == 1)
			reward2IKHFA.SetActive (true);
		else
			reward2IKHFA.SetActive (false);
		
		if (reward3IKHFAGot == 1)
			reward3IKHFA.SetActive (true);
		else
			reward3IKHFA.SetActive (false);

		if (reward4IKHFAGot == 1)
			reward4IKHFA.SetActive (true);
		else
			reward4IKHFA.SetActive (false);
		
		if (reward5IKHFAGot == 1)
			reward5IKHFA.SetActive (true);
		else
			reward5IKHFA.SetActive (false);		

		//bates

		if (reward1IQLABGot == 1)			
			reward1IQLAB.SetActive (true);
		else			
			reward1IQLAB.SetActive (false);
		
		if (reward2IQLABGot == 1)
			reward2IQLAB.SetActive (true);
		else
			reward2IQLAB.SetActive (false);
		
		if (reward3IQLABGot == 1)
			reward3IQLAB.SetActive (true);
		else
			reward3IQLAB.SetActive (false);

		if (reward4IQLABGot == 1)
			reward4IQLAB.SetActive (true);
		else
			reward4IQLAB.SetActive (false);
		
		// if (reward5IQLABGot == 1)
		// 	reward5IQLAB.SetActive (true);
		// else
		// 	reward5IQLAB.SetActive (false);

		
	}
}
