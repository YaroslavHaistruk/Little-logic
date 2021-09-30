using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
	public static int Points;
    public Rigidbody2D rb;
	public float moveSpeed = 1;
	Vector2 move;
	public Animator animator;
	public GameObject panellose;
	public GameObject panelfinish;
	
	void Start ()
	{
		Points = 0;
	}
   
    void Update()
    {
		animator.SetFloat("Horizontal", move.x);
		animator.SetFloat("Vertical", move.y);
		animator.SetFloat("Speed", move.sqrMagnitude);
		if(Points == 2)
		{
			panelfinish.SetActive(true);
		}
    }
	
	void FixedUpdate()
	{
		rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
	}
	public void moveLeft()
	{
		move.x = -5f;
	}
	public void moveRight()
	{
		move.x = 5f;
	}
	public void moveUp()
	{
		move.y = 5f;
	}
	public void moveDown()
	{
		move.y = -5f;
	}
	public void stopmoveHorizontal()
	{
		move.x = 0;
	}
	public void stopmoveVertical()
	{
		move.y = 0;
	}
	
	void OnTriggerEnter2D(Collider2D cl)
    {
        if (cl.gameObject.tag == "Finish")
        {
			panellose.SetActive(true);
        }
    }
}
