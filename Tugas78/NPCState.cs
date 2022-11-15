using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCState : MonoBehaviour
{
    GameObject Player;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Player.transform.position) < 5)
        {
            anim.SetBool("isDekat", true);
        }
        else
        {
            anim.SetBool("isDekat", false);
        }
    }
}
