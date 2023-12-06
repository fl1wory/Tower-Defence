using UnityEngine;

using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 10.0f;
    public float border = 10.0f;
    public float scrollSpeed = 2.0f;

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.mousePosition.y >= Screen.height - border)
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.mousePosition.y <= border)
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.mousePosition.x >= Screen.width - border)
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.mousePosition.x <= border)
        {
            pos.x -= speed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y += scroll * scrollSpeed * 100f * Time.deltaTime;

        transform.position = pos;
    }
}