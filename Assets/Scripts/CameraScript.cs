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
        transform.position = new Vector3(transform.position.x, transform.position.y, playerTrans.position.z+1);
    }
}
