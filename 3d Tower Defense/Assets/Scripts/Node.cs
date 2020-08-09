using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 offSet;

    private Renderer _renderer;
    private Color _defaultColor;
    private GameObject _turret;

    void Start()
    {        
        _renderer = GetComponent<Renderer>();
        _defaultColor = _renderer.material.color;
    }

    void OnMouseDown()
    {
        Debug.Log("MouseDown works!");
        if (_turret != null)
        {
            Debug.Log("Can't build here, something already here");
            return;
        }

        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        _turret = Instantiate(turretToBuild, transform.position + offSet, transform.rotation);
    }

    void OnMouseEnter()
    {
        Debug.Log("MouseEnter works!");
        _renderer.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        Debug.Log("MouseExit works!");
        _renderer.material.color = _defaultColor;
    }
}