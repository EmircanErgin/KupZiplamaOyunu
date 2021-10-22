using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class durdur : MonoBehaviour
{
    public static bool OyunDur = false;
    public GameObject DurdurMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(OyunDur)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        
    }
    public void Resume()
    {
        DurdurMenu.SetActive(false);
        Time.timeScale = 1f;
        OyunDur = false;

    }
   void Pause()
    {
        DurdurMenu.SetActive(true);
        Time.timeScale = 0f;
        OyunDur = true;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("GirisEkrani");
    }

    public void QuitGame()
    {
        Debug.Log("Oyundan Çıkıyor...");
        Application.Quit();
    }
}
