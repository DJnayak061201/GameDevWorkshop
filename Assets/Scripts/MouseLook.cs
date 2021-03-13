using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform playerBody;
    public float sens = 20f;
    float localRot;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;
        localRot -= mouseY;
        localRot=Mathf.Clamp(localRot, -90f, 90f);
        transform.localRotation = Quaternion.Euler(localRot, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
