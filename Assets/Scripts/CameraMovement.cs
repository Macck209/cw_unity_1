using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float xAxis=0f;
    private float yAxis = 0f;
    private float zAxis = 0f;

    public GameObject bullet;
    void Start()
    {
    }

    void Update()
    {
        xAxis = Input.GetAxis("Horizontal");
        yAxis = Input.GetAxis("yMovement");
        zAxis = Input.GetAxis("Vertical");

        transform.Translate(xAxis*Time.deltaTime*3, yAxis * Time.deltaTime * 3, zAxis*Time.deltaTime*3);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bulletInstance = Instantiate(bullet,transform.position,transform.rotation);
            bulletInstance.transform.parent=this.transform;

            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            bulletInstance.GetComponent<Rigidbody>().AddForce(fwd*300);
        }
    }
}
