using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float Xsense;
    public float Ysense;
    float XRot;
    float YRot;
    public Transform orientation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * Xsense;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * Ysense;

        YRot += mouseX;
        XRot -= mouseY;

        XRot = Mathf.Clamp(XRot, -90f, 90f);

        transform.rotation = Quaternion.Euler(XRot, YRot, 0);
        orientation.rotation = Quaternion.Euler(0, YRot, 0);
    }
}
