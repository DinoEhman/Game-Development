using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class PlayerNetwork : NetworkBehaviour
{
    public GameObject firstPersonCharacter;
    public GameObject[] characterModel;

    public override void OnStartLocalPlayer()
    {
        GetComponent<FirstPersonController>().enabled = true;
        firstPersonCharacter.SetActive(true);

        foreach(GameObject go in characterModel)
        {
            go.SetActive(false);
        }
    }
}
