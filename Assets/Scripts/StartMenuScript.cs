using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        StartCoroutine(ChangeLevel());
        Application.LoadLevel(1);
    }

    public void ExitGame()
    {
        Application.Quit();

        UnityEditor.EditorApplication.isPlaying = false;

    }

     IEnumerator ChangeLevel()
    {
        GameObject fader = GameObject.Find("FaderScripts");
        FaderScript faderScript = fader.GetComponent<FaderScript>();

        float fadeTime = faderScript.BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
    }
}
