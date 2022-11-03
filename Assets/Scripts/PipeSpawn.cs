using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Pipe;
    public GameObject Tree;    
    private float timeBtwSpawn, timeTreeSpawn;
    public float StartTimeBtwSpawn, StartTimeTreeSpawn;
    private Vector3  Newpos;
    float yP;
    void Start()
    {
        yP = Random.Range(-3.1f, 2.5f);
        Newpos = new Vector3(transform.position.x, yP, transform.position.z);
        //PipeStart();
       // transform.position = Vector2.;
        

    }

    // Update is called once per frame
    void Update()
    {
        PipeStart();

        TreeStart();
    }

    public void PipeStart()
    {
        if (timeBtwSpawn <= 0)
        {
            Instantiate(Pipe, Newpos, transform.rotation);
            timeBtwSpawn = StartTimeBtwSpawn;
        }
        else
        {
            // timeBtwSpawn = Time.deliteTime
            timeBtwSpawn -= Time.deltaTime; //равно этому - timeBtwSpawn = timeBtwSpawn - Time.deltaTime;
        }
    }
    public void TreeStart()
    {
        if (timeTreeSpawn <= 0)
        {
            Instantiate(Tree, transform.position, transform.rotation);
            timeTreeSpawn = StartTimeTreeSpawn;
        }
        else
        {
            timeTreeSpawn -= Time.deltaTime;
        }
    }

    
}
