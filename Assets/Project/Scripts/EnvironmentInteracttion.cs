using UnityEngine;

public class EnvironmentInteracttion : MonoBehaviour
{
    [SerializeField] private InfoDetialSO infoDetialSO;
    [SerializeField] private PointOfInterestController pointOfInterestController;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        pointOfInterestController.ProtofolioLoading(infoDetialSO);
    }
}
