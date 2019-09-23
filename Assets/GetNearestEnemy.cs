using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetNearestEnemy : MonoBehaviour
{
    private string ttag = "enemy";
    private Transform target;

    private Transform NearestEnemy = null;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("getNearestEnemy", 0, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void getNearestEnemy()
    {
        GameObject[] taggedEnemys = GameObject.FindGameObjectsWithTag(ttag);
        float NearestDistSqr = Mathf.Infinity;
        Transform NearestEnemy = null;
        foreach (GameObject taggedEnemy in taggedEnemys)
        {
            float distance = (transform.position - taggedEnemy.transform.position).sqrMagnitude;
          
             if (distance < NearestDistSqr)
             {
                 NearestDistSqr = distance;
                 NearestEnemy = taggedEnemy.transform;
             }
            
        }
        NearestEnemy.transform.GetComponent<MeshRenderer>().material.color = Color.green;
        target = NearestEnemy;
    }
}
