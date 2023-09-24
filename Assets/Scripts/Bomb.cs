using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bomb : MonoBehaviour   
{
    [SerializeField] private float radius;

    // Start is called before the first frame update
    void Start()
    {
        //Cooldown(5f);
        //Explode();
        RaycastHit2D hit = Physics2D.CircleCast(this.transform.position, radius, Vector3.one);
        if(hit.collider.CompareTag("IA"))
        {
            //Avisa que foi acertado a IA.

            //Dentro da ia:
            // MATA IA
        }
    }        
}
