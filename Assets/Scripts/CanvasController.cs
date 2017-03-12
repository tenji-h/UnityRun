using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour {

    // Use this for initialization
    static Canvas S1canvas;
    public UnityEngine.UI.Text LifeText;
    public UnityEngine.UI.Text TimeText;
    public UnityEngine.UI.Text ScoreText;
    public UnityEngine.UI.Text CenterText;
    float Endtime;
    float Scoretime;
    public static int Life;
    public static int Score;

    IEnumerator Start()
    {
        S1canvas = GameObject.FindObjectOfType<Canvas>();
        enabled = false;
        Life = 1;
        Endtime = 180;
        Score = 0;
        Scoretime = 0;

        CenterText.text = "ダンジョンを目指せ！";
        yield return new WaitForSeconds(2f);
        CenterText.text = "３";
        yield return new WaitForSeconds(1f);
        CenterText.text = "２";
        yield return new WaitForSeconds(1f);
        CenterText.text = "１";
        yield return new WaitForSeconds(1f);
        CenterText.text = "ＳＴＡＲＴ";
        yield return new WaitForSeconds(1f);
        CenterText.text = "";
        GameObject.Find("unitychan").GetComponent<UnitychanController>().enabled = true;
        GameObject.Find("unitychan").GetComponent<Animator>().enabled = true;

        enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        Endtime -= Time.deltaTime;
        //ライフ表示
        LifeText.text = new string('♥',Life);
        if (Life == 0)
        {
            SetGameover();
        }

        //残り時間表示
        if (Life > 0)
        {
            //Endtime -= 1 * Time.deltaTime;
            TimeText.text = "TIME： " + string.Format("{0:00}:{1:00}", (int)(Endtime / 60), Endtime % 60);
            if (Endtime == 0)
            {
                SetGameover();
            }
        }

        //スコア表示
        if (Life > 0)
        {
            Scoretime -= Time.deltaTime;
            if (Scoretime <= 0.0)
            {
                Scoretime = 1.0f;
                Score += 10;
                ScoreText.text = "SCORE：" + Score.ToString("D8");
            }
        }
    }

    public void Goalmessage()
    {
        CenterText.text = "ゴ ー ル ";



    }

    // 表示・非表示を設定する
    public static void SetActive(string name, bool b)
    {
        foreach (Transform child in S1canvas.transform)
        {
            // 子の要素をたどる
            if (child.name == name)
            {
                child.gameObject.SetActive(b);
                return;
            }
        }
        // 指定したオブジェクト名が見つからなかった
        Debug.LogWarning("Not found objname:" + name);
    }

    // ゲームオーバー処理
    public void SetGameover()
    {
        //GameObject.Find("unitychan").GetComponent<UnitychanController>().enabled = false;
        //GameObject.Find("unitychan").GetComponent<Animator>().enabled = false;
        CenterText.text = "ゲーム オーバー";
        SetActive("Button1", true);
        SetActive("Button2", true);


    }
}
