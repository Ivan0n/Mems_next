using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // Объект, который нужно спавнить
    public GameObject objectToSpawn;
    public GameObject objectToSpawn2;
    

    // Радиус, в пределах которого объекты будут спавниться
    public float spawnRadius = 2.0f;

    // Количество объектов для спавна за один раз
    public int numberOfObjects = 1;

    public void SpawnObjects2()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            // Выбираем случайное положение вокруг объекта в заданном радиусе
            Vector3 randomPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            randomPosition.y = transform.position.y; // Оставляем высоту объекта на том же уровне

            // Спавним объект
            Instantiate(objectToSpawn2, randomPosition, Quaternion.identity);
            
        }
    }
    // Метод для спавна объектов
    public void SpawnObjects()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            // Выбираем случайное положение вокруг объекта в заданном радиусе
            Vector3 randomPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            randomPosition.y = transform.position.y; // Оставляем высоту объекта на том же уровне

            // Спавним объект
            Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
            
        }
    }
    private void Start()
    {
        InvokeRepeating("SpawnObjects", 0, 50);
        InvokeRepeating("SpawnObjects2", 0, 140);
    }
}
