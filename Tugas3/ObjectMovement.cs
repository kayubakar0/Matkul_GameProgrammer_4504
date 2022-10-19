using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    Vector3 kekanan;
    Vector3 kekiri;
    Vector3 keatas;
    Vector3 kebawah;

    Vector3 maju;
    Vector3 mundur;

    public int aksi;
    // Start is called before the first frame update
    void Start()
    {
        kekanan = new Vector3(1,0,0);
        kekiri = new Vector3(-1,0,0);
        keatas = new Vector3(0,1,0);
        kebawah = new Vector3(0,-1,0);
        maju = new Vector3(0,0,1);
        mundur = new Vector3(0,0,-1);
    }
    
    void OnCollisionEnter2D(Collision2D coll){
        if (coll.gameObject.tag == "EnemyTag"){
            UnityEngine.Debug.Log("Mulai Nabrak");
        }
    }
    void OnCollisionStay2D(Collision2D coll){
        if (coll.gameObject.tag == "EnemyTag"){
            UnityEngine.Debug.Log("Sedang Nabrak");
        }
    }
    void OnCollisionExit2D(Collision2D coll){
        if (coll.gameObject.tag == "EnemyTag"){
            UnityEngine.Debug.Log("Sudah Nabrak");
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch(aksi){
        case 0:
            transform.position = transform.position + (kekanan * 2f * Time.deltaTime);
            break;
        case 1:
            transform.position = transform.position + (kekiri * 2f * Time.deltaTime);
            break;
        case 2:
            transform.position = transform.position + (keatas * 2f * Time.deltaTime);
            break;
        case 3:
            transform.position = transform.position + (kebawah * 2f * Time.deltaTime);
            break;
        case 4:
            transform.rotation = transform.rotation * RotasiObjek.toQuaternion(maju * 2f * Time.deltaTime);
            break;
        case 5:
            transform.rotation = transform.rotation * RotasiObjek.toQuaternion(mundur * 2f * Time.deltaTime);
            break;
        }
    }
}
