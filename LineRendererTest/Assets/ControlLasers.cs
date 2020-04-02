using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLasers : MonoBehaviour
{
    public Laser laser1;
    public Laser laser2;
    public Laser laser3;
    private bool isRunning;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        isRunning = false;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(LaserShooting());
        
      
    }

    private IEnumerator LaserShooting()
    {
        //int count = 0;
        if(Input.GetKey(KeyCode.Space))
        {

               
                StartCoroutine(laser1.LaserShot());
                yield return StartCoroutine(laser2.LaserShot());
            StartCoroutine(laser3.LaserShot());
            


        }
    }
    private IEnumerator Shoot()
    {
        int i = 0;
        while(i<2)
        {
            StartCoroutine(laser1.LaserShot());
            yield return StartCoroutine(laser2.LaserShot());
            i++;
        }

    }
}
