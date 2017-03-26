using UnityEngine;
using System.Collections;

public class CameraScript2 : MonoBehaviour {

    public GameObject player;
    private Transform playerTrans;

    void Start()
    {
        playerTrans = player.GetComponent<Transform>();
        StartCoroutine("LookPL");
    }

    void Update()
    {

        //transform.LookAt(playerTrans);
        transform.RotateAround(Vector3.zero, Vector3.up, -15 * Time.deltaTime);
        //transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z + 0.05f);
    }

    private IEnumerator LookPL()
    {
        transform.LookAt(playerTrans);
        transform.rotation=Quaternion.Euler(0,transform.rotation.y,0);
        yield return new WaitForSeconds(1);
    }
}
