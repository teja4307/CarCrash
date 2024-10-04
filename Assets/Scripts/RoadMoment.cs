using System.Collections;
 //System.Cusingollections.Generic;
using UnityEngine;

public class RoadMoment : MonoBehaviour
{
    public Transform[] Road;
    //float y_val;

    public void Update()
    {
        //y_val = y_val - 5 * Time.deltaTime;
        
      for(int i=0;i<Road.Length; i++)
        {
            if (GameManager._inst.start == true)
            {
                Road[i].transform.localPosition = new Vector3(Road[i].transform.localPosition.x, 
                                                              Road[i].transform.localPosition.y - GameManager._inst.speed * Time.deltaTime,
                                                              Road[i].transform.localPosition.z);

            }

            if (Road[i].transform.localPosition.y<-10.5f)
            {
                if(i==0)
                {
                    Road[0].transform.localPosition += new Vector3(Road[1].transform.localPosition.x, Road[1].transform.localPosition.y + 21f,
                                                                 0);
                }
                if (i == 1)
                {
                    Road[1].transform.localPosition += new Vector3(Road[0].transform.localPosition.x, Road[0].transform.localPosition.y + 21f,
                                                                 0);
                }
            }
        }
        

    }
}
