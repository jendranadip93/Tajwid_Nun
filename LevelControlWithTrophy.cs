using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControlWithTrophy : MonoBehaviour
{

	// Get references to game objects that should be disabled and enabled
	// at the start
	GameObject[] toEnable, toDisable;

	// References to game objects that should be enabled
	// when correct or incorrect answer is given
	public GameObject correctSign, incorrectSign, reward; //trophySing;

	// Variable to contain current scene build index
	int currentSceneIndex;

	// Variable name to pass to Player Prefs meaning which variable to set as got
	// Adjustable in inspector depending on current scene and trophy
	// you earn (if you do)
	public string whichRewardGot = "Reward1Got";

	// Use this for initialization
	void Start () {

		// Getting current scene build index
		currentSceneIndex = SceneManager.GetActiveScene ().buildIndex;

		// Finding game objects with tags "ToEnable" and "ToDisable"
		toEnable = GameObject.FindGameObjectsWithTag ("ToEnable");
		toDisable = GameObject.FindGameObjectsWithTag ("ToDisable");

		// Disabling game objects with tag "ToEnable"
		foreach (GameObject element in toEnable)
		{
			element.gameObject.SetActive (false);
		}

	}

	// Method is invoked when correct answer is given
	public void RightAnswer()
	{
		// Disabling game objects that are no longer needed
		foreach (GameObject element in toDisable)
		{
			element.gameObject.SetActive (false);
		}

		// Turn on "correct" sign
		correctSign.gameObject.SetActive (true);

		// Getting a value if you already got current trophy
		int Rewardgot = PlayerPrefs.GetInt(whichRewardGot);

		// If you already got current trophy
		if (Rewardgot == 1)

			// then you proceed to next level
			Invoke ("LoadNextLevel", 2f);

		// if you don't have current trophy yet
		else
			// then GetTrophy method is invoked in 1 second
			Invoke ("GetTrophy", 2f);
	}

	// Method is invoked if incorrect answer is given
	public void WrongAnswer()
	{
		// Disabling game objects that are no longer needed
		foreach (GameObject element in toDisable)
		{
			element.gameObject.SetActive (false);
		}

		// Turn on "incorrect" sign
		incorrectSign.SetActive (true);

		// if wrong answer u can go to the next level
		Invoke ("LoadNextLevel", 2f);
	}

	// Method is invoked if you don't have current trophy yet
	void GetTrophy()
	{
		// "Correct" sing is turned on
		correctSign.SetActive (false);

		// Trophy game object is shown
		reward.SetActive (true);

		// "You got new trophy" sign is shown
		//trophySing.SetActive (true);

		// Set Player Prefs whichCupGot variable so you got this trophy
		// to store this value between the scenes
		PlayerPrefs.SetInt (whichRewardGot, 1);

		// Invoke LoadNextLevel method in 1 second
		Invoke ("LoadNextLevel", 2f);
	}

	// Method loads next level depending on current scenes build index
	void LoadNextLevel()
	{
		SceneManager.LoadScene (currentSceneIndex + 1);
	}

	// Method loads MainMenu scene
	//void GotoMenuPlay()
	//{
	//	SceneManager.LoadScene ("MenuPlay");
	//}
}
