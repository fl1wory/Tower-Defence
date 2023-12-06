using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Turret", menuName = "Turret")]

public class TurretData : ScriptableObject
{
    [Header("Turret Stats")]
    [SerializeField]private int _damage, _price;
    [SerializeField]private float _fireRate, _speedBullet;
    [SerializeField]private string _turretName;
    [SerializeField]private bool _canRotate;

    [Header("Visuals")]
    [SerializeField] private Sprite _turretSprite;
    [SerializeField] private GameObject _modelTurret;

    public bool CanRotate
    {
        get{ return _canRotate; }
        set{ _canRotate = value; }
    }

    public int Damage
    {
        get{ return _damage; }
        set{ _damage = value; }
    }

    public int Price
    {
        get{ return _price; }
        set{ _price = value; }
    }

    public string TurretName
    {
        get{ return _turretName; }
        set{ _turretName = value; }
    }

    public float FireRate
    {
        get{ return _fireRate; }
        set{ _fireRate = value; }
    }

    public float SpeedBullet
    {
        get{ return _speedBullet; }
        set{ _speedBullet = value; }
    }

    public Sprite TurretSprite
    {
        get{ return _turretSprite; }
        set{ _turretSprite = value; }
    }

    public GameObject ModelTurret
    {
        get{ return _modelTurret; }
        set{ _modelTurret = value; }
    }
}
