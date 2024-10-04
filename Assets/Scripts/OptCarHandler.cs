using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptCarHandler : MonoBehaviour
{
    public Transform[] cars;
    //float y_val;

    public void Update()
    {
        //y_val = y_val - 5 * Time.deltaTime;
        for (int i = 0; i < cars.Length; i++)
        {
            if(GameManager._inst.start==true)
            {
                cars[i].transform.localPosition = new Vector3(cars[i].transform.localPosition.x, 
                                                              cars[i].transform.localPosition.y - GameManager._inst.speed * Time.deltaTime,
                                                              cars[i].transform.localPosition.z);
            }
            

            if (cars[i].transform.localPosition.y < -32f)
            {
                if (i == 0)
                {
                    cars[0].transform.localPosition += new Vector3(cars[1].transform.localPosition.x, cars[1].transform.localPosition.y + 60f,
                                                                 0);
                }
                if (i == 1)
                {
                    cars[1].transform.localPosition += new Vector3(cars[0].transform.localPosition.x, cars[0].transform.localPosition.y + 60f,
                                                                 0);
                }
            }
        }


    }
}
