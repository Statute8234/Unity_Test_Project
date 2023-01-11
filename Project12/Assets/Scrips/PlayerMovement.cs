using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    public GameObject Player;
    private Vector3 direction;
    
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0)) {
            direction = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction.z = 0;
            Player.transform.position = direction;
        }
    }
}
