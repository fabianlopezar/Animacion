using UnityEngine;
using TMPro;

public class RayCast : MonoBehaviour
{


    public GameObject prefabBala;
    public bool shot = false;

    public float _shotForce = 1500;
    public float _shotRate = 0.5f;
    public float _shotRateTime = 0.0f;
    
    
    public TMP_Text _textoTMP;
    public int counter=0;
    public float rayLength = 30f;


    private void Start()
    {
        _textoTMP.text = "0";
    }
    void Update()
    {
        Rayo();
    }

    private void Rayo()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * 30f, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Destroy(hit.transform.gameObject);
            counter++;
            _textoTMP.text = "" + counter;
            Debug.DrawRay(ray.origin, ray.direction * 30f, Color.green);
        }
    }
}
