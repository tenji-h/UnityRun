using UnityEngine;
using System.Collections;

public class RabbitController : MonoBehaviour {

    private float speed;
    private Vector3 st;

    // Use this for initialization
    void Start()
    {
        speed = 0.03f;
        st = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0, 180, 0);
        transform.position = new Vector3(0, 0, transform.position.z);
        transform.position += transform.forward * speed;

        float dis = Vector3.Distance(st, this.transform.position);
        if (dis > 15f)
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
