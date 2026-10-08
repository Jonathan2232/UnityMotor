using UnityEngine;

public class Variables : MonoBehaviour
{
    [SerializeField] private int variable = 99;

    public Color color = new Color(0f, 0f, 0f, 0f);

    public int getVariable()
    {
        return variable;
    }

    public void setVariable(int value)
    {
        variable = value;
    }
    void Start()
    {
        Debug.Log("Start" + gameObject.name);
        Debug.Log(variable);
        Debug.Log(color);
    }
}