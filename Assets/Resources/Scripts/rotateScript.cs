using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateScript : MonoBehaviour
{/*
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
*/
        
}
