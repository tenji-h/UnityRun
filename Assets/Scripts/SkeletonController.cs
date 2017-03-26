using UnityEngine;
using System.Collections;

public class SkeletonController : MonoBehaviour {

    float time;
    Animator animator;
    string[] action;

    // Use this for initialization
    void Start () {
        action = new string[]{ "Attack1", "Attack2" };
        animator = this.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        time = time + Time.deltaTime;
        if (time > 5f)
        {
            //Debug.Log("action");
            time = 0;
            animator.SetTrigger(action[Random.Range(0, action.Length)]);
        }

    }
}
