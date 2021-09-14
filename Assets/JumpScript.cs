using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    [SerializeField] private LayerMask platformLayerMask;
    
    private Rigidbody2D rigidbody2D;
    private Transform transform;

    private BoxCollider2D boxCollider2D;
    // Start is called before the first frame update
    void Start()
    {

        transform = GetComponent<Transform>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    } 

    // Update is called once per frame
    void Update()
    {
        bool jumpbuttonpressed = Input.GetKeyDown(KeyCode.Space);
        Vector2 jumpPreset;
        jumpPreset.y = 15;
        jumpPreset.x = 0;
        if (jumpbuttonpressed)
        {
            if (IsOnGround())
            {
                rigidbody2D.velocity += jumpPreset;
            }
        }
    }

    private bool IsOnGround()
    {
        float extraHeight = .01f;
        RaycastHit2D rayHit2 = Physics2D.Raycast(boxCollider2D.bounds.center, Vector2.down,
            boxCollider2D.bounds.extents.y + extraHeight, platformLayerMask);
        
        //RaycastHit2D rayHit = Physics2D.Raycast(transform.position, Vector2.down, transform.localScale.y / 2);
        /*Debug.DrawRay(transform.position, Vector2.down * (transform.localScale.y / 2) , Color.red);
        Debug.Log(transform.position);
        Debug.Log(transform.localScale.y / 2);*/
        Debug.Log(rayHit2.collider);
        return rayHit2.collider != null;
    }
}
