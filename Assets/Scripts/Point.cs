using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Point : MonoBehaviour
{
	public GameObject bluepoint;
	public GameObject redpoint;
	public GameObject paczkaRed;
	public GameObject paczkaBlue;
	
    void OnTriggerEnter2D(Collider2D cl)
    {
		if (cl.gameObject.tag == "paczkaRed")
        {
			Player.Points = Player.Points + 1;
			redpoint.SetActive(true);
			paczkaRed.SetActive(false);
        }
		if (cl.gameObject.tag == "paczkaBlue")
        {
			Player.Points = Player.Points + 1;
			bluepoint.SetActive(true);
			paczkaBlue.SetActive(false);
        }
		
    }
}
