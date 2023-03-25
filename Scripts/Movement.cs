using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed; 
    
    public Animator animator; 
    
    //Get input from player
    //Apply movement to sprite 
    
    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        Vector3 direction = new Vector3(horizontal, vertical);
        
        AnimateMovement(direction);
        
        transform.position += direction * speed * Time.deltaTime; 
    }
    
    void AnimateMovement(Vector3 direction)
    {
        if(animator != null)
        {
            if(direction.magnitude > 0)
            {
                animator.SetBool("isMoving", true);
                
                animator.SetFloat("horizontal", direction.x);
                animator.SetFloat("vertical", direction.y);
            } 
            else 
            {
                animator.SetBool("isMoving", false);
            }
        }
    }
}
