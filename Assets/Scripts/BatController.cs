using UnityEngine;
using System.Collections;

public class BatController : MonoBehaviour {

    private float speed;
    private Vector3 st;
    private Transform player;

    // Use this for initialization
    void Start()
    {
        speed = 0.07f;
        st = this.transform.position;
        player = GameObject.Find("unitychan").transform;

    }

    // Update is called once per frame
    void Update()
    {
        //transform.eulerAngles = new Vector3(0, 180, 0);
        //transform.position = new Vector3(0, 0, transform.position.z);
        Quaternion targetRotation = Quaternion.LookRotation(player.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 1f);
        transform.position += transform.forward * speed;

        float dis = Vector3.Distance(st, this.transform.position);
        if (GameObject.Find("unitychan").GetComponent<UnitychanController>().Kflg)
        {
            Destroy(this.gameObject);
        }

    }

    void OnCollisionEnter(Collision other)
    {
        //if (col.CompareTag("Damage"))
        if (other.gameObject.name == "unitychan")
        {
            speed = 0;
            this.GetComponent<Animator>().SetTrigger("Die");
            //Destroy(this.gameObject);
        }
    }

}
