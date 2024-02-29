using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetReward : MonoBehaviour
{
    // Reset All Player Preferences data to start earn trophies again
	public void ResetPlayerPrefs()
	{
		PlayerPrefs.DeleteAll ();

        Invoke ("LoadMainMenu", 1f);
	}

    void LoadMainMenu()
	{
		SceneManager.LoadScene ("Scene_Main_Menu");
	}
}
