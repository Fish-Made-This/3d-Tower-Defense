using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Vector3 offSet;

    private Renderer _renderer;
    private Color _defaultColor;
    private GameObject _turret;
    private BuildManager _buildManager;

    private void Start()
    {
        _buildManager = BuildManager.instance;
        _renderer = GetComponent<Renderer>();
        _defaultColor = _renderer.material.color;
    }

    private void OnMouseDown()
    {
        if (_buildManager.TurretToBuild == null) { return; }
        if (_turret != null) { return; }

        _turret = Instantiate(_buildManager.TurretToBuild, transform.position + offSet, transform.rotation);

    }

    private void OnMouseEnter()
    {
        if (_buildManager.TurretToBuild != null)
        {
            _renderer.material.color = hoverColor;
        }
    }

    private void OnMouseExit()
    {
        _renderer.material.color = _defaultColor;
    }
}