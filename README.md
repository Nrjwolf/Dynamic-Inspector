# Dynamic-Inspector

Scripts helps organise your inspector view

![Alt text](http://telegra.ph/file/830c3f56feb51a152fd46.gif "Example")

## Usage

1. Add ConditionalHidePropertyDrawer.cs to "Editor" folder
2. Add ConditionalHideAttribute.cs 
3. Now you can use it

### Bool

Code for 1st gif:
``` C#
public bool showList;
// Attribute name, disable or hide, inverse
[ConditionalHide("showList", false, false)]
public MyList myList;
[System.Serializable] public class MyList { public List<int> list; }
```

### Two bool variables

![Alt text](http://telegra.ph/file/37033d1d7e224b3cf160a.gif "Gif example")

``` C#
// Two attributes 
public bool bool1;
public bool bool2;
[ConditionalHide("bool1", ConditionalSourceField2 = "bool2")]
public float range = 0.0f;
```

### Enum

![Alt text](http://telegra.ph/file/9ba43bc2680e3bbf85045.gif "Gif example")

``` C#
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
```

> Email : nrjwolf@gmail.com
>
> Мой канал в телеграме : https://t.me/nrjwolf_live
