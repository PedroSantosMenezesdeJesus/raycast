using System.Collections;
using System.Security.Cryptography;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    Ray ray;
    RaycastHit hitData;
    Vector3 point;
    Color color;
    public Camera _camera;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("inicio");
        StartCoroutine(GerarTarget());

    }

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Input.GetKey(KeyCode.Mouse0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            color = Color.green;
            Lancar(ray, color, 1);
        }
        if (UnityEngine.Input.GetKey(KeyCode.Space))
        {
            ray = new Ray(transform.position, transform.forward);
            color = Color.yellow;
            Lancar(ray, color, 2);
        }
        if (UnityEngine.Input.GetKey(KeyCode.Return))
        {
            point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
            ray = _camera.ScreenPointToRay(point);
            color = Color.blue;
            Lancar(ray, color, 3);
        }
    }

    private void Lancar(Ray ray, Color color, int tipo)
    {
        Debug.Log("Origem:" + ray.origin);

        Debug.Log("Direção:" + ray.direction);

        if(Physics.Raycast(ray, out hitData))
        {
            Vector3 hitPosition = hitData.point;
            Debug.Log("hitPosition:" + hitData.point);

            float hitDistance = hitData.distance;
            Debug.Log("hitDistance:" + hitData.distance);

            string tag = hitData.collider.tag;
            Debug.Log("tag:" + tag);

            GameObject hitObject = hitData.transform.gameObject;
            Debug.DrawRay(ray.origin, ray.direction * 1000, Color.magenta);
            StartCoroutine(SphereIndicator(hitPosition, tipo));

            if (tag == "target")
            {
                Destroy(hitObject);
            }
        }

        else
        {
            Debug.DrawRay(ray.origin, ray.direction * 1000, Color.magenta);
            Debug.Log("errou!!!");
        }
    }

    private IEnumerator SphereIndicator(Vector3 pos, int tipo)
    {
        GameObject gameObj = null;
        switch(tipo)
        {
            case 1:
                gameObj = CriaObject(pos, "cherry");
                break;

            case 2:
                gameObj = InstanciaPrefab(pos);
                break;

            case 3: 
                gameObj = CriaObject(pos, "blue");
                break;

        }

        yield return new WaitForSeconds(1);
        Destroy(gameObj);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(ray);
    }

    GameObject CriaObject(Vector3 pos, string material)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = pos;
        sphere.transform.localScale = new Vector3(3, 3, 3);
        string src = string.Concat("material/", material);
        Material bombMaterial = Resources.Load(src, typeof(Material)) as Material;

        sphere.GetComponent<Renderer>().material = bombMaterial;
        return sphere;
    }

    GameObject InstanciaPrefab(Vector3 pos)
    {

        GameObject prefab = Resources.Load("prefab/bomb", typeof(GameObject)) as GameObject;

        return Instantiate(prefab, pos, Quaternion.identity);
    }

    private IEnumerator GerarTarget()
    {
        while (true)
        {
            float x = Random.Range(-150.0f, 80.0f);
            float y = Random.Range(-34.0f, 45.0f);
            float z = Random.Range(-50.0f, 5.0f);
            Vector3 position = new Vector3(x, y, z);
            Instantiate(Resources.Load("prefab/target", typeof(GameObject)) as GameObject, position, Quaternion.identity);
            yield return new WaitForSeconds(15);
        }
    }
}
