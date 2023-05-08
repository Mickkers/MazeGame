using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IControlable
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed;

    // Update is called once per frame
    void Update()
    {
        UpdatePosition();
        InputHandler();
    }

    private void UpdatePosition()
    {
        transform.position += direction * Time.deltaTime * speed;
    }
    public void InputHandler()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
    }
}
