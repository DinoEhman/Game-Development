using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

	void OnCollisionStay( Collision collision ){
		if(collision.gameObject.tag == "Ledja")
        {
            if (Input.GetMouseButtonDown(0))
            {
                Destroy(collision.gameObject.transform.parent.gameObject);
                Debug.Log("Luka je sretan");
            }
        }
	}


}
