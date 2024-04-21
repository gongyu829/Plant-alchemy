using UnityEngine;
using UnityEngine.EventSystems;

public class DropHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = FindObjectOfType<Canvas>();  // 确保找到场景中的Canvas
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Drag Start");
    }

    public void OnDrag(PointerEventData eventData)
    {
        //  Debug.Log(" Drag");
        Vector2 moveDelta = eventData.delta / canvas.scaleFactor;  // 考虑缩放因子
        rectTransform.anchoredPosition += moveDelta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Debug.Log("End Drag");
        // 射线投射来检测碰撞
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            // 检测到碰撞
            Debug.Log("Hit " + hit.collider.name);
        }
    }
}
