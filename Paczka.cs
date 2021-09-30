using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Paczka : MonoBehaviour
{
    public GameObject panelFinish;
	
    void OnTriggerEnter2D(Collider2D cl)
    {
        if (cl.gameObject.tag == "Finish")
        {
			panelFinish.SetActive(true);
        }
    }
}
