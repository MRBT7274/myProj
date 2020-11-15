using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exCountdown : MonoBehaviour
{
    private float time;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
        if (time >= 115)
        {
            time = 0;
            GameObject t = Instantiate(explosion, transform.position, Quaternion.identity);
            
            Destroy(t, 3);

        }
    }
}
