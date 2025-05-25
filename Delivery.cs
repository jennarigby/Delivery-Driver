using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColour = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColour = new Color32(1, 1, 1, 1);

    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;
    SpriteRenderer spriteRenderer; 

    void Start(){
        spriteRenderer= GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("OOPS!");
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColour;
            Destroy(other.gameObject, destroyDelay);
        }
        else if(other.tag == "Customer" && hasPackage){
            Debug.Log("Package delivered.");
            hasPackage = false;
            spriteRenderer.color = noPackageColour;
        }
    }
}
