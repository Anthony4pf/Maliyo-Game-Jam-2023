using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class AttackButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public LaserShooter laserShooter;

    public void OnPointerDown(PointerEventData eventData)
    {
        laserShooter.OnStartAtack();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        laserShooter.OnStopAttack();
    }
}