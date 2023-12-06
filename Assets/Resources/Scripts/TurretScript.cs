using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour
{/*
    [SerializeField] private Transform[] firePoints;
    [SerializeField] private GameObject bulletPrefab;
    public TurretData data;
    public GameObject range;
    
    private bool canRotate;
    private Transform target;
    private string name;


    void Awake()
    {
        fireRate = data.FireRate;
        speedBullet = data.SpeedBullet;
        name = data.TurretName;
        damage = data.Damage;
        canRotate = data.CanRotate;
    }

    void Start()
    {
        StartCoroutine(Shoot(fireRate));
    }

    void Update()
    {
        
        if(target)
        {
            transform.GetChild(0).GetChild(0).LookAt(target.position, Vector3.up);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!target && other.tag is "Enemy")
        {
            target = other.transform.GetChild(0);
        }
    }

    

    IEnumerator Shoot(float delay)
    {
        if(target)
        {
            foreach(Transform firePoint in firePoints)
            {
                Rigidbody rb = Instantiate(bulletPrefab,
                    firePoint.position, firePoint.rotation).GetComponent<Rigidbody>();
                rb.AddForce(firePoint.forward);
            }
        }
        yield return new WaitForSeconds(delay);
        StartCoroutine(Shoot(delay));
    }*/
}
