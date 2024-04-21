using UnityEngine;

public class Icon : MonoBehaviour
{
    public Vector3 initialPosition; // UI图标的初始位置



    private void OnCollisionEnter(Collision collision)
    {
        // 检测碰撞的物体是否是3D模型
        if (collision.gameObject.CompareTag("3DModel"))
        {
            // 调用Manager类的DecreaseIconCount方法
            Manager.Instance.DecreaseIconCount();

            // 将UI图标移动回初始位置
            transform.position = initialPosition;
        }
    }
}