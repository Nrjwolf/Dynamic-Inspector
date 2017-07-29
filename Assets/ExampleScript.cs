using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
	[Header("Bool")]
    public bool showList;
	// Attribute name, disable or hide, inverse
	[ConditionalHide("showList", false, false)]
    public MyList myList;
	[System.Serializable] public class MyList { public List<int> list; }

	[Header("Two Bool variables")]
	// Two attributes 
	public bool bool1;
	public bool bool2;
	[ConditionalHide("bool1", ConditionalSourceField2 = "bool2")]
	public float range = 0.0f;

	[Header("Enum")]
	public MyType type;
	[ConditionalHide("type", (int)MyType.ONE, false)]
	public int one;
	[ConditionalHide("type", (int)MyType.TWO, false)]
	public int two;
	[ConditionalHide("type", (int)MyType.TREE, false)]
	public int tree;
	public enum MyType {
		ONE,
		TWO,
		TREE
	} 
}
