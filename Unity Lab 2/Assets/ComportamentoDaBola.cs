using UnityEngine;

public class ComportamentoDaBola : MonoBehaviour
{

    public float XRotacao = 0;
    public float YRotacao = 1;
    public float ZRotacao = 0;
    public float GrausPorSegundo = 180;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 eixo = new Vector3(XRotacao, YRotacao, ZRotacao);
        transform.RotateAround(Vector3.zero, eixo, GrausPorSegundo * Time.deltaTime);
        Debug.DrawRay(Vector3.zero, eixo, Color.yellow, .5f);

    }
}
