string someString = "abc#d##c";
Stack<char> stack = new Stack<char>();

foreach (var chars in someString)
{
    if (chars == '#')
    {
        if (stack.Count > 0)
            stack.Pop();
    }
    else
    {
        stack.Push(chars);
    }
}

var array = stack.ToArray();
Array.Reverse(array);
string clrdString = new string(array);
Console.WriteLine(clrdString);
