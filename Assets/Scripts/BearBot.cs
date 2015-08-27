using UnityEngine;
using System.Collections;

public class BearBot : MonoBehaviour {

	private Animator animator;

	// Use this for initialization
	void Start () {
	
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Hooray()
	{
		animator.SetTrigger ("Hooray");
	}
	
	public void Hello()
	{
		animator.SetTrigger ("Hello");
	}
	
	public void SlideLeft()
	{
		animator.SetTrigger ("SlideLeft");
	}

}
