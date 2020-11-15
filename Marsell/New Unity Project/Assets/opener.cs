using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opener : MonoBehaviour
{
    public GameObject character;
    public float CRange;
    private Animator anonim;
    // Start is called before the first frame update
    void Start()
    {
        anonim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {if (Vector3.Distance(character.transform.position, transform.position)<CRange)         {
            anonim.SetBool("character_nearby", true);
        }
        else
        {
            anonim.SetBool("character_nearby", false);
        }
        
    }
}
