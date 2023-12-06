using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateScript : MonoBehaviour
{
    public float radius = 10f; // радіус пошуку ворогів
    public string enemyTag = "enemy"; // тег ворога
    public GameObject headPart;
    public GameObject mountPart;
    public float speed;
    [HideInInspector] public GameObject nearestEnemy;
    [HideInInspector] public Quaternion lookRotation;

    void Update()
    {
        nearestEnemy = FindNearestEnemy();
        if (nearestEnemy != null)
        {
            RotateTurret(nearestEnemy.transform);
        }
    }

    GameObject FindNearestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        GameObject nearestEnemy = null;
        float minDistance = Mathf.Infinity;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < minDistance && distanceToEnemy <= radius)
            {
                minDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        return nearestEnemy;
    }

    void RotateTurret(Transform target)
    {
        Vector3 direction = target.position - headPart.transform.position;
        lookRotation = Quaternion.LookRotation(direction);
        Vector3 rotation = Quaternion.Lerp(headPart.transform.rotation, lookRotation, speed).eulerAngles;
        headPart.transform.rotation = Quaternion.Euler(rotation.x, rotation.y, 0f);
        mountPart.transform.rotation = Quaternion.Euler(0f, rotation.y, 0f);
    }    
}
