using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] Transform weaponObjectsContainer;
    [SerializeField] WeaponData startingWeapon;

    public void Start()
    {
        addWeapon(startingWeapon);
    }

    public void addWeapon(WeaponData weaponData)
    {
        GameObject weaponObject = Instantiate(weaponData.weaponPrefab, weaponObjectsContainer);

        weaponObject.GetComponent<WeaponBase>().SetData(weaponData);
    }
}
