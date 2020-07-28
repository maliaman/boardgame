using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Tile currentTile;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonUp(0)) {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100.0f)) {
            
            if (hit.transform != null) {

                print("Matt is cool :)");

                Rigidbody p1;

                if (p1 = hit.transform.GetComponent<Rigidbody>()) {

                     currentTile = currentTile.nextTile;

                     //this.transform.position = currentTile.transform.position;

                     this.transform.position.Set(2, 
                                                 2, 
                                                 2);

                     print(currentTile.name);
                }
            }
        }
        
    }

}

}
