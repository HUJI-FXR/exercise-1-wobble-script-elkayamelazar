using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WobbleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(Mathf.Sin(1.22f * Time.time),
            Mathf.Sin(Mathf.PI * Time.time), Mathf.Sin(1.5f * Time.time));

        transform.localScale = new Vector3(Mathf.Sin(13.13f * Time.time),
            Mathf.Sin(2.78f * Time.time), Mathf.Sin(Time.time));

        transform.Rotate(Mathf.Sin(5.66f * Time.time),
            Mathf.Sin(3f * Time.time), Mathf.Sin(0.99f * Time.time));

        GetComponent<Rigidbody>().mass = Mathf.Sin(7.457f * Time.time);
    }
}
