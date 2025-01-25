using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // ������, ������� ����� ��������
    public GameObject objectToSpawn;
    public GameObject objectToSpawn2;
    

    // ������, � �������� �������� ������� ����� ����������
    public float spawnRadius = 2.0f;

    // ���������� �������� ��� ������ �� ���� ���
    public int numberOfObjects = 1;

    public void SpawnObjects2()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            // �������� ��������� ��������� ������ ������� � �������� �������
            Vector3 randomPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            randomPosition.y = transform.position.y; // ��������� ������ ������� �� ��� �� ������

            // ������� ������
            Instantiate(objectToSpawn2, randomPosition, Quaternion.identity);
            
        }
    }
    // ����� ��� ������ ��������
    public void SpawnObjects()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            // �������� ��������� ��������� ������ ������� � �������� �������
            Vector3 randomPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            randomPosition.y = transform.position.y; // ��������� ������ ������� �� ��� �� ������

            // ������� ������
            Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
            
        }
    }
    private void Start()
    {
        InvokeRepeating("SpawnObjects", 0, 50);
        InvokeRepeating("SpawnObjects2", 0, 140);
    }
}
