using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] protected EnemyData eData;
    [SerializeField] private GameObject shootPoint;
    [SerializeField] private GameObject enemyBulletPrefab;
    //[SerializeField] private float distanceRay = 20f;
    //[SerializeField] private int coolDown = 4;
    //[SerializeField] private float timeShoot = 4;
    //private bool canshoot = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {if (eData.canshoot) {
        RaycastShoot();
    }
    else
    {
            eData.timeShoot += Time.deltaTime;
    }
    if(eData.timeShoot > eData.coolDown)
    {
            eData.canshoot = true;
    }
        
    }

    private void RaycastShoot()
    {
        RaycastHit hit;
       if (Physics.Raycast(shootPoint.transform.position, shootPoint.transform.TransformDirection(Vector3.forward), out hit, eData.distanceRay))
       {
           Debug.Log("Player detectado");
            eData.canshoot = false;
            eData.timeShoot = 0;
           GameObject b = Instantiate(enemyBulletPrefab, shootPoint.transform.position, enemyBulletPrefab.transform.rotation);
           b.GetComponent<Rigidbody>().AddForce(shootPoint.transform.TransformDirection(Vector3.forward) * 10f, ForceMode.Impulse);
       }
    }
    private void OnDrawGizmos()
    { 
        Gizmos.color = Color.green;
        Gizmos.DrawRay(shootPoint.transform.position, shootPoint.transform.TransformDirection(Vector3.forward) * eData.distanceRay);
    }
}
