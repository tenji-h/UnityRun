using UnityEngine;
using System.Collections;

public class UnitychanController : MonoBehaviour {

    public float speed;
    Animator animator;
    AnimatorStateInfo animStateInfo;
    public bool Gflg;

    // Use this for initialization
    void Start()
    {
        speed = 0.05f;
        animator = this.GetComponent<Animator>();
        Gflg = false;
    }

    // Update is called once per frame
    void Update () {

        animStateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if (animStateInfo.nameHash == Animator.StringToHash("Base Layer.DownToUP"))
        {
            if (animStateInfo.normalizedTime <= 1.0f)    //アニメーション終了したら
            {
                speed = 0.05f;

            }
        }

        transform.eulerAngles = new Vector3(0, 0, 0);
        transform.position = new Vector3(0, transform.position.y, transform.position.z);
        transform.position += transform.forward * speed;
    }

    public void OnTapped()
    {
        animator.SetTrigger("Jump");
        this.GetComponent<Rigidbody>().AddForce(Vector3.up * 4.5f, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            CanvasController.Life -= 1;
            speed = 0;
            Destroy(other.gameObject);
            if (CanvasController.Life <= 0)
            {
                this.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
                animator.SetTrigger("Gameover");
            }
            else
            {
                animator.SetTrigger("Damage");
            }
        }
    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            Gflg = true;
            for (int i = 1; i < 5; i++)
            {
                speed -= 0.01f;
                yield return new WaitForSeconds(1f);
            }
            animator.SetTrigger("Goal");
            speed = 0;
        }
    }

    public void OnCallChangeFace()
    {
    }

}
