using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {

    public void Button1Push()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void Button2Push()
    {
    }

    public void Button3Push()
    {
        Application.Quit();
    }
}
