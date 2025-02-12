using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    public GameObject targetPrefab;
    public int howManyTargets = 5;
    public List<GameObject> targets;

    private void Start()
    {
        targets = new List<GameObject>();
        for(int i =0; i < howManyTargets; i++)
        {
           GameObject newTarget = Instantiate(targetPrefab);
            newTarget.transform.position = Random.insideUnitCircle * 4;

            Targ t = newTarget.GetComponent<Targ>();
            t.spawner = this;
            targets.Add(newTarget);
        }
    }
    public void Stampy(GameObject t)//Stampy is Target hit because Hit the target 43:31
    {
        targets.Remove(t);
    }
}
