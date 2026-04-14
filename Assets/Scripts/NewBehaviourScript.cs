using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  void onTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "walls")
        {
          print("ENTER") ;   
           }
    }

void onTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "walls")
        {
         print("STAY") ;   
           }
    }

void onTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "walls")
        {
            print("EXIT") ;   
           }
    }

}
