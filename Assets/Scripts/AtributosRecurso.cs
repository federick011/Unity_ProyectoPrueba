using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributosRecurso : MonoBehaviour
{
    //estado del recurso bueno = 0 o malo = 1, si es malo no produce nada
    public int EstadoDelRecurso;
    //Tamaño del recurso pequeño = 0, mediano = 1, grande = 2
    public int TamanoDelRecurso;
    //la cantidad de Recurso que produce segun su tipo y tamaño madera, etc... Es publico para poder acceder a ellos
    public float CantidadDeRecursos;
    //Para instanciar el objeto nuevo
    GameObject ClonObjetoRecurso;
    public GameObject ObjetoRecursoPrefab;
    
    
	// Use this for initialization
	void Start ()
    {
		if(EstadoDelRecurso == 0)
        {
            switch (TamanoDelRecurso)
            {
                case 0:
                    CantidadDeRecursos = 5f;
                    break;
                case 1:
                    CantidadDeRecursos = 10f;
                    break;
                case 2:
                    CantidadDeRecursos = 15f;
                    break;
            }
        }
        else
        {
            CantidadDeRecursos = 0;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        //destruimos el objeto cuando se acaben los recursos del mismo
        if (CantidadDeRecursos < 1)
        {
            ClonObjetoRecurso =Instantiate(ObjetoRecursoPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), ObjetoRecursoPrefab.transform.rotation);
            Destroy(this.gameObject);
        }
	}
}
