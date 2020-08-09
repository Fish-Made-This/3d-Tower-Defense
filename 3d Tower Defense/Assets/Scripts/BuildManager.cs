using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    public GameObject standardTurretPrefab;

    private GameObject _turretToBuild;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
            return;
        }
        instance = this;
    }

    void Start()
    {
        _turretToBuild = standardTurretPrefab;
    }

    public GameObject GetTurretToBuild()
    {
        return _turretToBuild;
    }
}
