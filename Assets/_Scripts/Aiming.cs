using UnityEngine;

public class Aiming : MonoBehaviour
{
    public Camera playerCamera;
    public float aimFOV = 30f;
    public float normalFOV = 60f;
    public float aimSpeed = 5f;
    public float aimSensitivity = 50f;
    public float normalSensitivity = 100f;
    private MouseLook mouseLook;

    void Start()
    {
        mouseLook = GetComponent<MouseLook>();
    }

    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            // Aiming
            playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, aimFOV, aimSpeed * Time.deltaTime);
            mouseLook.mouseSensitivity = aimSensitivity;
        }
        else
        {
            // Normal view
            playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, normalFOV, aimSpeed * Time.deltaTime);
            mouseLook.mouseSensitivity = normalSensitivity;
        }
    }
}
