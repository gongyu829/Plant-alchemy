using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dianji : MonoBehaviour
{

    public GameObject ui1; // 指定的图标预制体
    public GameObject[] GameObject; // 图标生成的位置
    public int clickCount = 0; // 点击次数

    private static int index = 0;

    public bool isro;
    public GameObject obj;

    void OnMouseDown()
    {
        Debug.Log("点击了");
        //if(obj.activeSelf == false)
        if (!isro)
        {
            for (int i = 0; i < GameObject.Length; i++)
            {
                if (GameObject[i].transform.childCount == 0)
                {
                    obj = Instantiate(ui1, GameObject[i].transform);
                    obj.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
                    obj.name = "ui" + index++;

                    isro = true;
                    break;
                }
            }

        }
        else
        {
            obj.transform.Find("Text").GetComponent<Text>().text = (++clickCount).ToString();
            obj.SetActive(true);
            obj.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;
        }

    }
}