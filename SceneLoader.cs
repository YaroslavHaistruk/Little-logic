using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
	public int scene;
	
    public void SceneLoad(int sn)
    {
        SceneManager.LoadScene(sn);
    }
	public void Exit()
    {
        Application.Quit();
    }
	void OnTriggerEnter2D(Collider2D cl)
    {
		if (cl.gameObject.tag == "paczka")
        {
			SceneManager.LoadScene(scene);
        }
		if (cl.gameObject.tag == "paczkaBlue")
        {
			Application.Quit();
        }
		
    }
}
