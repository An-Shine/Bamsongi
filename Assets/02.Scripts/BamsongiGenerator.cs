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
            mousePosition.z = 10f; // ī�޶���� �Ÿ�

           Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

           // �������� ������ ��ġ
           Vector3 spawnPosition = new Vector3(worldPosition.x, worldPosition.y, 0f);

            //������ ����
           Instantiate(bamsongiPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
