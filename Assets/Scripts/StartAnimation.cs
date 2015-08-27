using UnityEngine;
using System.Collections;

public class StartAnimation : MonoBehaviour 
{
	Animator anim;
	GameObject bearbot;
	// Use this for initialization
	public void TriggerAnimation () 
	{
		Debug.Log ("Clicked");
		anim = GetComponent<Animator> ();


		//GameObject bearbot = GetComponent<GameObject> ("BearBot");
		//animabearbottion.Play("Hooray");

	}
	
}
