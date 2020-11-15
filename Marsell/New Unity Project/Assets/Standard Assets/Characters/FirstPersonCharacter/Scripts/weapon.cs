using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class weapon : MonoBehaviour
{   public GameObject bullet;
    public Transform muzzle;
    public int curAmmo;
    public int maxAmmo;
    public float speed;
    public float fireRate;
    private float lastShootTime;
    public bool isPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        if (GetComponent<FirstPersonController>())
        {
            isPlayer = true;
        } 
    }

    private void Awake()
    {
        
    }

    public bool CanShoot()
    { if (Time.time - lastShootTime >= fireRate)
        {
            if (curAmmo > 0)
            {
                return true;
            }
        }
        return false;
    }
     
    public void Shoot()
    {
        lastShootTime = Time.time;
        curAmmo -=5;
        GameObject projectile = Instantiate(bullet, muzzle.position,muzzle.rotation) ;
        projectile.GetComponent<Rigidbody>().velocity = muzzle.forward * speed;
        Destroy(projectile,3);
        
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
