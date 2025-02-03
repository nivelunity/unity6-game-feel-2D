using UnityEngine;

public class Rifle : MonoBehaviour
{
    
    [SerializeField] private Transform _proyectilSpawn;
    [SerializeField] private Proyectil _proyectilPrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Disparar();
    }

    private void Disparar()
    {
        if (Input.GetMouseButtonDown(0)) {
            GenerarProyectil();
        }
    }

    private void GenerarProyectil()
    {
        Proyectil nuevoProyectil = Instantiate(_proyectilPrefab, _proyectilSpawn.position, Quaternion.identity);
    }
}
