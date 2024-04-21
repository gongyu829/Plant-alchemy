using UnityEngine;

public class ToggleObject : MonoBehaviour
{
    public GameObject guo; // 要切换显示/隐藏的物体

    void Start()
    {
        // 设置物体的初始状态为隐藏
        guo.SetActive(false);
    }

    public void ToggleVisibility()
    {
        // 切换物体的显示/隐藏状态
        guo.SetActive(!guo.activeSelf);
    }
}