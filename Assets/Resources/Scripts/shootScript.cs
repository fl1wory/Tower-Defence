using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootScript : MonoBehaviour
{

//////////////////////////////////////////////
    public float fireRate;
    private float damage;
    private bool canRotate;
    public float bulletSpeed;
    private float nextShootTime;
    public GameObject bulletPrefab;
    private Transform target;
    public float speed;
//////////////////////////////////////////////

//////////////////////////////////////////////
    public Transform[] firePoints;    
    public GameObject[] shootFlashes;
    //public GameObject range;
//////////////////////////////////////////////

//////////////////////////////////////////////
    public TurretData data;
//////////////////////////////////////////////

//////////////////////////////////////////////
    public GameObject headPart;
    public GameObject mountPart;
    private Quaternion lookRotation;
//////////////////////////////////////////////


    void Awake()
    {
        fireRate = data.FireRate;
        bulletSpeed = data.SpeedBullet;
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
        if(!canRotate){return;}
        if(target)
        {
            Debug.Log("rotating");
            RotateTurret(target);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger true");
        if(!target && other.tag == "Enemy")
        {
            target = other.transform;
            Debug.Log("traget true");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("trigger false");
        if(other.transform == target)
        {
            target = null;
            Debug.Log("traget false");
        }
    }

    IEnumerator Shoot(float delay)
    {
        foreach(Transform firePoint in firePoints)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.transform);
            Destroy(bullet, 0.3f);
            bullet.transform.position = firePoint.position;
            bullet.transform.rotation = Quaternion.Euler(Quaternion.Lerp(headPart.transform.rotation, lookRotation, 0.08f).eulerAngles.x, Quaternion.Lerp(headPart.transform.rotation, lookRotation, 0.08f).eulerAngles.y, 0f);
            bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletSpeed, ForceMode.Impulse);
            Debug.Log("shoot");
        }

        foreach(GameObject shootFlash in shootFlashes)
        {
            shootFlash.GetComponent<ParticleSystem>().Play();
        }

        yield return new WaitForSeconds(delay);
        StartCoroutine(Shoot(delay));
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
