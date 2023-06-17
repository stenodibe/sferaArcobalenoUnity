using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float velocità;
    private float orizzontale;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        orizzontale = Input.GetAxis("Horizontal");
       // transform.Get(Vector3.forward * orizzontale * velocità * Time.deltaTime);
    }
}
