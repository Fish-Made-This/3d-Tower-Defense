using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 15f;

    private Transform _target;
    private int _wayPointIndex;

    void Start()
    {
        _target = Waypoints.waypoints[_wayPointIndex];
    }

    void Update()
    {
        var direction = _target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(_target.position, transform.position) <= 0.2f)
        {
            GetNextWaypoint();

        }
    }

    private void GetNextWaypoint()
    {
        if (_wayPointIndex == Waypoints.waypoints.Length - 1)
        {
            Destroy(gameObject);
        }
        else
        {
            _wayPointIndex++;
            _target = Waypoints.waypoints[_wayPointIndex];
        }        
    }
}
