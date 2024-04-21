using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager Instance { get; private set; }

    public int iconCount = 10;
    public int progress = 0;

    public GameObject[] prefabs; // 存储你的预设体
    public Vector3 spawnPosition; // 指定生成位置

    private List<int> _indexList = new List<int>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        for (int i = 0; i < prefabs.Length; i++)
        {
            _indexList.Add(i);

        }
        Debug.Log("111");
    }

    public void DecreaseIconCount()
    {
        iconCount--;
    }

    public void IncreaseProgress()
    {
        progress++;
    }

    public int GetProgress()
    {
        return progress;
    }

    public void NextStep()
    {
        // 在这里实现下一步的逻辑
        SpawnPrefab();
    }

    private void SpawnPrefab()
    {
        if (_indexList.Count == 0)
        {
            Debug.Log("All prefabs have been spawned.");
            return;
        }
        // 在指定位置生成预设好的9个3D模型中的一个
        int index = _indexList[Random.Range(0, _indexList.Count)];
        _indexList.Remove(index);
        //GameObject obj = Instantiate(prefabs[index], spawnPosition, Quaternion.identity);
        prefabs[index].SetActive(true);
        Debug.Log("显示植物：" + index);
        progress = 0;
    }

}