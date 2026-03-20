using UnityEngine;
using UnityEngine.InputSystem;

namespace AA0000
{
    public class FindingStuff : MonoBehaviour
    {
        [SerializeField] private GameObject targetForDragNDropWay;
        [SerializeField] private GameObject targetGameobjectForNameFinding;
        [SerializeField] private Transform targetTransformForNameFinding;
        [SerializeField] private GameObject targetForTagFinding;
        [SerializeField] private GameObject targetForTypeFinding;
        //[SerializeField] private Dice[] targetsForFindingWithOfType;
        //[SerializeField] private GameObject targetForGetComponentFinding;
        //[SerializeField] private ThingToFind theThingToFindComponent;
        //[SerializeField] private GameObject targetForGetComponentInChildrenFinding;
        [SerializeField] private Key activationKey = Key.F;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Start()
        {
            //targetForNameFinding = GameObject.Find("== Week 04 ==");
            //targetForNameFinding = GameObject.Find("PuppetCylinder");
            targetGameobjectForNameFinding = GameObject.Find("Cat");
            targetTransformForNameFinding = targetGameobjectForNameFinding.transform.Find("Cat"); //Used the found gameobject by name and tood its transform and search for a child called ChildCube

            targetForTagFinding = GameObject.FindGameObjectWithTag("Food");

            //targetForTypeFinding = GameObject.FindFirstObjectByType<ThingToFind>().gameObject;

            //targetsForFindingWithOfType = FindObjectsByType<Dice>(FindObjectsInactive.Include, FindObjectsSortMode.InstanceID);

            //targetForGetComponentFinding = GetComponent<ThingToFind>().gameObject;
            //theThingToFindComponent = GetComponent<ThingToFind>();

            //targetForGetComponentInChildrenFinding = GetComponentInChildren<ThingToFind>(true).gameObject;
        }

        // Update is called once per frame
        void Update()
        {
            if (Keyboard.current[activationKey].wasPressedThisFrame)
            {
                FindMeThings();
            }
        }
        private void FindMeThings()
        {
            targetGameobjectForNameFinding = GameObject.Find("Cat");

            targetForTagFinding = GameObject.FindGameObjectWithTag("Food");

            targetForTypeFinding = GameObject.FindFirstObjectByType<Transform>().gameObject;

            //targetForGetComponentFinding = GetComponent<MovingTarget>().gameObject;

            //targetForGetComponentInChildrenFinding = GetComponentInChildren<MovingTarget>(true).gameObject;
        }

    }

}