using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0.5f, -1, 0) * Time.deltaTime * 4f);

        if (transform.position.y >= -8.5f)
        {
            return;
        }
        Destroy(gameObject);
    }
}
