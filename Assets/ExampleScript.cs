using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
	[System.Serializable] public class MyList { public List<int> list; }

    public bool showList;
	[ConditionalHide("showList", false, false)]
    public MyList myList;
}
