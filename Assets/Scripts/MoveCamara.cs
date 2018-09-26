using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamara : MonoBehaviour
{

    public Vector3 PosRayo;
    public RaycastHit GolpeRayo;
    Vector2 touchDeltaPosition;

    //para que la camara siga al jugador
    public GameObject player;       

    private Vector3 offset;

    // Use this for initialization
    void Start ()
    {
        transform.position =new Vector3(player.transform.position.x-10, player.transform.position.y+16, transform.position.z-5);
        Screen.SetResolution(800, 600, true);
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
        
    }
   
    // Update is called once per frame
    void Update ()
    {
        
        if (Input.GetMouseButtonUp(0))
        {

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out GolpeRayo, 100))
            {
                PosRayo = GolpeRayo.point;
                //Comprobamos que se haya topado con un objeto llamado "Terrain"

                  Debug.Log("Numero de recursos producidos " + Input.touches/*+ GolpeRayo.collider.gameObject.GetComponent<AtributosRecurso>().CantidadDeRecursos*/);
                //vemos si colpea a una recurso y empieza a quitarle
               
                if (GolpeRayo.collider.tag == "Arbol")
                {
                    GolpeRayo.collider.GetComponent<AtributosRecurso>().CantidadDeRecursos--;
                }
            }
        }


       

    }
    private void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = player.transform.position + offset;

        //mover la camara con el dedo
       /* if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(-touchDeltaPosition.x * 0.05f, -touchDeltaPosition.y * 0.05f, -touchDeltaPosition.y * 0.05f);
        }*/
    }



}
