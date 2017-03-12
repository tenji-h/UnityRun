using UnityEngine;
using System.Collections;

public class SlimeController : MonoBehaviour {

    private float speed;

	// Use this for initialization
	void Start () {
        speed = 0.03f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * speed;

    }

    void OnTriggerEnter(Collider col)
    {
        speed = 0;
        this.GetComponent<Animator>().SetTrigger("Die");
        //Destroy(this.gameObject);
    }
}
