using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public AudioSource playSound;
    public AudioSource quitSound;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("ÇIKIŞ");
        Application.Quit();
    }

    public void playSong()
    {
        playSound.Play();
        quitSound.Stop();
    }

    public void quitSong()
    {
        playSound.Stop();
        quitSound.Play();
    }
    
}
