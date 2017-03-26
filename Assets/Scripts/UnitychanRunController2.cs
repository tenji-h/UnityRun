using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UnitychanRunController2 : MonoBehaviour {

    [SerializeField]
    private UnitychanController2 unitychanController;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;
            if (Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.transform.gameObject.tag.Contains("Unitychan"))
                {
                    this.unitychanController.OnTapped();
                }
            }
        }

        if (Input.GetButtonDown("Jump"))
        {
            this.unitychanController.OnTapped();
        }

        if (this.unitychanController.Gflg)
        {
            GetComponent<CanvasController>().Goalmessage();
            //SceneManager.LoadScene("Stage2");

        }

        //途中終了
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }

}
