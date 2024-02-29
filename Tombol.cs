using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tombol : MonoBehaviour
{
    public void exit()
    {
        Application.Quit();
    }

    public void LoadToScene(string tombolLanjut)
    {
        SceneManager.LoadScene(tombolLanjut);
    }

    public void sound_volume(float volume)
    {
        PlayerPrefs.SetFloat("volume",volume);
    }
}
