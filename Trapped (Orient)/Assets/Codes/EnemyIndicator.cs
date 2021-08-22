using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]

public class EnemyIndicator : MonoBehaviour
{
    public float detectRange;
    private Light light;
    private Dictionary<GameObject, float> enemyDists;
    private List<GameObject> keys;
    private Color colorChange;
    private float minDist;

    private void Start()
    {
        //Dictionary for enemy distances per enemy
        enemyDists = new Dictionary<GameObject, float> { };

        light = GetComponent<Light>();
    }

    private void Update()
    {
        //Set default value to 255 per enemy
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            if (g.GetComponent<EnemyAI>() != null && !enemyDists.ContainsKey(g))
            {
                enemyDists.Add(g, 255f);
                keys = new List<GameObject>(enemyDists.Keys);           //Necessary for writing purposes
            }
        }

        //Determine closest enemy on continuously updating distances
        minDist = 4;
        if (enemyDists.Count > 0)
        {
            foreach (GameObject key in keys)
            {
                enemyDists[key] = Vector2.Distance(transform.position, key.transform.position);
                if (enemyDists[key] < minDist)
                {
                    minDist = enemyDists[key];
                }
            }
        }

        //Change spotlight color appropriately
        colorChange = new Color(1 - (minDist / detectRange), light.color.g, light.color.b, light.color.a);
        light.color = colorChange;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectRange);
    }

    public void clearReferences(GameObject[] toBeRemoved)
    {
        foreach (GameObject g in toBeRemoved)
        {
            enemyDists.Remove(g);
        }
    }
}
