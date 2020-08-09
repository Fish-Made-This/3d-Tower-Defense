using UnityEngine;

public class Shop : MonoBehaviour
{

    private BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }


    public void PurchaseStandardTurret()
    {
        buildManager.TurretToBuild = buildManager.standardTurretPrefab;
    }

    public void PurchaseLaserTurret()
    {
        buildManager.TurretToBuild = buildManager.laserTurretPrefab;
    }

    public void PurchaseMisseleTurret()
    {
        buildManager.TurretToBuild = buildManager.missileTurretPrefab;
    }
}
