using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Transform originalParent;

    public void OnBeginDrag(PointerEventData eventData)
    {
        originalParent = transform.parent;
        transform.SetParent(GameObject.Find("Canvas").transform);

    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        print("End Drag");
        // 射线投射来检测碰撞
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            // 检测到碰撞
            Debug.Log("Hit " + hit.collider.name);
            if (hit.collider.name == "guo")
            {
                Debug.Log("3D object hit: " + hit.transform.name);
                // 在这里处理3D物体的逻辑
                // 消失并回到UI栏，数量减一
                gameObject.SetActive(false);
                transform.SetParent(originalParent);
                transform.position = Vector3.zero;

                Manager.Instance.DecreaseIconCount();

                // 累积一个进度
                Manager.Instance.IncreaseProgress();
                Debug.Log(Manager.Instance.GetProgress());
                // 进度为三时进行下一步
                if (Manager.Instance.GetProgress() >= 3)
                {
                    Manager.Instance.NextStep();

                }
            }
        }
        else
        {
            transform.SetParent(originalParent);
            transform.GetComponent<RectTransform>().anchoredPosition = Vector3.zero;

        }
    }
}