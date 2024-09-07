using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    void Start()
    {
       
    }

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           // GameObject bamsongi = Instantiate(bamsongiPrefab);

            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10f; // 카메라와의 거리

           Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

           // 프리팹을 생성할 위치
           Vector3 spawnPosition = new Vector3(worldPosition.x, worldPosition.y, 0f);

            //프리팹 생성
           Instantiate(bamsongiPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
