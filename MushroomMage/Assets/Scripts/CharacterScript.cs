using System.Collections;
using System.Collections.Generic;
using UnityEditor.EventSystems;
using UnityEngine;
using UnityEngine.UIElements;

public class CharacterScript : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    public Animator anim;
    public GameObject reticle;
    public Rigidbody rb;
    public Vector3 direction;
    public Vector3 mouseWorldPosition;
    public float angle;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Ray ray1 = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray1, out RaycastHit raycastHit1))
        {
            mouseWorldPosition = new Vector3(raycastHit1.point.x, 0, raycastHit1.point.z);
        }
        reticle.transform.position = mouseWorldPosition;
        direction = reticle.transform.position - transform.position;
        transform.LookAt(mouseWorldPosition);
        mainCamera.ScreenToWorldPoint(Input.mousePosition);
        float dirX = Input.GetAxisRaw("Horizontal");
        float dirZ = Input.GetAxisRaw("Vertical");
        Debug.Log(transform.position);
        if (dirX != 0 || dirZ != 0)
        {
            anim.SetBool("IsMoving", true);
        }
        else if (dirX == 0 && dirZ == 0)
        {
            anim.SetBool("IsMoving", false);
        }
        rb.velocity = new Vector3(dirX * 12f, 0f,dirZ * 12f);
    }
}
