using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public GameObject player;
    private Transform playerTrans;

    void Start()
    {
        playerTrans = player.GetComponent<Transform>();
    }

    void Update()
    {

        if (GameObject.Find("unitychan").GetComponent<UnitychanController>().Kflg)
        {
            if (transform.position.x > 0)
            {
                transform.LookAt(playerTrans);
                transform.RotateAround(Vector3.zero, Vector3.up, -1 * Time.deltaTime);
                transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z + 0.05f);
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, playerTrans.position.z + 1);
        }

    }
}
