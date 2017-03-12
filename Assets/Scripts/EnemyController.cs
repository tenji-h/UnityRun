using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public GameObject player;
    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    private int AreaFlg1;
    private int AreaFlg2;
    private int AreaFlg3;

    // Use this for initialization
    void Start () {
        AreaFlg1 = 0;
        AreaFlg2 = 0;
        AreaFlg3 = 0;
        //Instantiate(Enemy1, new Vector3(0, 0, -60), Quaternion.Euler(0, 180, 0));

    }

    // Update is called once per frame
    void Update () {
        if (Mathf.Floor(player.transform.position.z) == -65 && AreaFlg1 == 0)
        {
            Instantiate(Enemy1, new Vector3(0, 0, -50), Quaternion.Euler(0, 180, 0));
            Instantiate(Enemy1, new Vector3(0, 0, -35), Quaternion.Euler(0, 180, 0));
            AreaFlg1 = 1;
        }
        if (Mathf.Floor(player.transform.position.z) == -30 && AreaFlg2 == 0)
        {
            Instantiate(Enemy2, new Vector3(0, 0, -20), Quaternion.Euler(0, 180, 0));
            Instantiate(Enemy2, new Vector3(0, 0, -5), Quaternion.Euler(0, 180, 0));
            Instantiate(Enemy2, new Vector3(0, 0, 5), Quaternion.Euler(0, 180, 0));
            AreaFlg2 = 1;
        }
        if (Mathf.Floor(player.transform.position.z) == 20 && AreaFlg3 == 0)
        {
            Instantiate(Enemy3, new Vector3(0, 0, 30), Quaternion.Euler(0, 180, 0));
            Instantiate(Enemy3, new Vector3(0, 0, 40), Quaternion.Euler(0, 180, 0));
            Instantiate(Enemy3, new Vector3(0, 0, 45), Quaternion.Euler(0, 180, 0));
            AreaFlg3 = 1;
        }

    }
}
