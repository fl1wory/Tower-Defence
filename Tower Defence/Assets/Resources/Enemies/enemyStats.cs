using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyStats : MonoBehaviour
{
    public float HP;
    public float speed;
    public string[] resistances;


    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Bullet")
        {
            HP = HP - collider.gameObject.GetComponent<bullet>().damage;
        }
    }
}
