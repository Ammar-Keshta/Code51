using System.Collections;
using System.Collections.Generic;
using BNG;
using JetBrains.Annotations;
using UnityEngine;

public class ModelReset : MonoBehaviour
{
    public Transform[] MainPosition;
    public AudioSource AS;
    public int id;
    
    public void Start()
    {

    }

    public void OnEnable()
    {

    }

    void Update()
    {
        
      


    }



    void OnRealseModle()
    {
        if (Vector3.Distance(transform.position, MainPosition[0].position) < 0.13F)
        {
            this.GetComponent<Rigidbody>().isKinematic = true;



            AS.Play();
                transform.position = MainPosition[0].position;
                transform.rotation = MainPosition[0].rotation;

            
            if (id == 0) { FindFirstObjectByType<PuzzelManger>().Buzzels[0] = true; }
            }

        
        else
        {
            this.GetComponent<Rigidbody>().isKinematic = false;
           // FindFirstObjectByType<PuzzelManger>().Sokets[0] = false;

        }

        if (Vector3.Distance(transform.position, MainPosition[1].position) < 0.13F)
        {
          

                this.GetComponent<Rigidbody>().isKinematic = true;


                AS.Play();
                transform.position = MainPosition[1].position;
                transform.rotation = MainPosition[1].rotation;
            

            if (id == 1) { FindFirstObjectByType<PuzzelManger>().Buzzels[1] = true;
            }

        }
        else
        {
            //   this.GetComponent<Rigidbody>().isKinematic = false;
          //  FindFirstObjectByType<PuzzelManger>().Sokets[1] = false;


        }


        if (Vector3.Distance(transform.position, MainPosition[2].position) < 0.13F)
        {
           
                this.GetComponent<Rigidbody>().isKinematic = true;



                AS.Play();
                transform.position = MainPosition[2].position;
                transform.rotation = MainPosition[2].rotation;
            

            if (id == 2) { FindFirstObjectByType<PuzzelManger>().Buzzels[2] = true; }


        }
        else
        {
            //FindFirstObjectByType<PuzzelManger>().Sokets[2] = false;
            //    this.GetComponent<Rigidbody>().isKinematic = false;


        }


        if (Vector3.Distance(transform.position, MainPosition[3].position) < 0.13F)
        {
           
                this.GetComponent<Rigidbody>().isKinematic = true;


                AS.Play();
                transform.position = MainPosition[3].position;
                transform.rotation = MainPosition[3].rotation;
            

            if (id == 3) { FindFirstObjectByType<PuzzelManger>().Buzzels[3] = true; }


        }
        else
        {
           // FindFirstObjectByType<PuzzelManger>().Sokets[3] = false;

            // this.GetComponent<Rigidbody>().isKinematic = false;

        }


    }
    public void ONGrab() { FindFirstObjectByType<PuzzelManger>().Buzzels[id] = false; }



   


}
