using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootScript : MonoBehaviour
{
    public float shootSpeed;
    public GameObject bulletPrefab;
    public float bulletSpeed;
    private Transform bulletSpawnPoint;
    private float nextShootTime;
    private GameObject headPart;
    private Quaternion lookRotation;
    public GameObject shootFlash;

    void Start()
    {
        headPart = GetComponent<rotateScript>().headPart;
        lookRotation = GetComponent<rotateScript>().lookRotation;
    }

    void Update()
    {
        if(GetComponent<rotateScript>().nearestEnemy != null && Time.time > nextShootTime)
        {
            nextShootTime = Time.time + shootSpeed;
            Shoot();
        }
    }

    public void Shoot()
    {
        shootFlash.SetActive(true);
        GameObject bullet = Instantiate(bulletPrefab, bulletPrefab.transform);
        bullet.transform.position = bulletPrefab.transform.position;
        bullet.transform.rotation = Quaternion.Euler(Quaternion.Lerp(headPart.transform.rotation, lookRotation, 0.08f).eulerAngles.x, Quaternion.Lerp(headPart.transform.rotation, lookRotation, 0.08f).eulerAngles.y, 0f);
        bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward * bulletSpeed, ForceMode.Impulse);
        Debug.Log("shoot");
        Destroy(bullet, 0.3f);
        shootFlash.SetActive(false);
    }
}
