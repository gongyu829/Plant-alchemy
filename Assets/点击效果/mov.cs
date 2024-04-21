using UnityEngine;
using UnityEngine.Video;

public class ClickHandler : MonoBehaviour
{
    public VideoClip videoClip; // 存储你的.mov视频

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 检测鼠标左键点击或手指点击屏幕
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (videoClip == null) return;
                // 在点击的位置创建一个新的游戏对象，并添加VideoPlayer组件
                GameObject videoObject = new GameObject("VideoPlayer");
                videoObject.transform.position = hit.point;
                VideoPlayer videoPlayer = videoObject.AddComponent<VideoPlayer>();

                // 设置VideoPlayer组件的属性
                videoPlayer.playOnAwake = false;
                videoPlayer.clip = videoClip;

                // 播放视频
                videoPlayer.Play();
                Destroy(videoObject, (float)videoClip.length);
            }
        }
    }
}