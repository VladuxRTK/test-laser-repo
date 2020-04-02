using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public Transform laserHit;
    // public Transform laserHit2;
    //   public Transform laser1;
    // public Transform laser2;
    private int count;

    Vector3 d;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.enabled = false;
        lineRenderer.useWorldSpace = true;
        d = transform.up;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
      

        //Destroy(hit.transform.gameObject);

        //RaycastHit2D hit1 = Physics2D.Raycast(transform.position, -transform.up);
        // laserHit.position = hit.point;
        // laserHit.position = hit.point;
        // laserHit2.position = hit1.point;
        lineRenderer.SetPosition(0, this.transform.position);
        lineRenderer.SetPosition(1, laserHit.position);
      
       /* lineRenderer.SetPosition(2, laser2.position);
        lineRenderer.SetPosition(3, laserHit2.position);*/
        
        
        //Debug.DrawLine
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
            Destroy(collision.gameObject);
    }*/

    public IEnumerator LaserShot()
    {


    
            
            lineRenderer.enabled = true;
            yield return new WaitForSeconds(0.5f);
            lineRenderer.enabled = false;
            yield return new WaitForSeconds(0.5f);
            lineRenderer.enabled = true;
            yield return new WaitForSeconds(0.5f);
            lineRenderer.enabled = false;   
           
        




    }

}
