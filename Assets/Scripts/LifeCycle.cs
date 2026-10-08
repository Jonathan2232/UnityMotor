using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    private int i;
    
    public LifeCycle()
    {
        i = 33;
    }

    void Awake()
    {
        Debug.Log(" Ciclo Awake" + gameObject.name);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Comienzo" + gameObject.name);
    }

    void FixedUpdate()
    {
        //Debug.Log(" Ciclo FixedUpdate" + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update" + gameObject.name);
    }

    void LateUpdate()
    {
        //Debug.Log(" Ciclo LateUpdate" + gameObject.name);
    }

    void OnEnable()
    {
        Debug.Log("OnEnable" + gameObject.name);
    }

    void OnDisable()
    {
        Debug.Log("OnDisable" + gameObject.name);
    }

    void OnDestroy()
    {
        Debug.Log("OnDestroy" + gameObject.name);
    }
    
    
}
