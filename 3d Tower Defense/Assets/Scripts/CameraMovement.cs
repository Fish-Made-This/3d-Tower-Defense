using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float panSpeed = 30f;
    public float panBorderThickness = 10f;
    public float scrollspeed = 5f;

    public float minY = 10f;
    public float maxY = 80f;

    void Update()
    {
        // Handle movement
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) || Input.mousePosition.y <= panBorderThickness)
        {
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.mousePosition.x <= panBorderThickness)
        {
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }

        // Handle scrolling
        float scroll = 0f;
        if (Input.GetKey(KeyCode.PageUp))
        {
            // increase keypress by by 100
            scroll = panSpeed * Time.deltaTime * 100;
        }

        if (Input.GetKey(KeyCode.PageDown))
        {
            // increase keypress by by 100
            scroll = -panSpeed * Time.deltaTime * 100;
        }

        if (Input.GetAxis("Mouse ScrollWheel") != 0f)
        {
            // scrolling is really slow, so increase by 1000
            scroll = Input.GetAxis("Mouse ScrollWheel") * 1000; 
        }

        var pos = transform.position;
        pos.y -= scroll * scrollspeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;
    }
}
