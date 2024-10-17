using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    // Start is called before the first frame update
    void OnJump()
    {

        Debug.Log("jumpy boi");

    }
    void OnInteract()
    {

        Debug.Log("interacty boi");

    }

    public void Interact()
    {
        OnInteract();
    }

}
