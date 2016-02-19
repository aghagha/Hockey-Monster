using UnityEngine;
using System.Collections;

public class ContainerController : MonoBehaviour 
{
    private Animator animator;

	// Use this for initialization
	void Start ()
    {
        animator = this.GetComponent<Animator>();	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void Open()
    {
        transform.localScale = Vector2.one;
        if (animator != null)
            animator.Play("StartAnim");
    }

    public void Close()
    {
        transform.localScale = Vector2.zero;
        if (animator != null)
            animator.Play("Empty");
    }
}
