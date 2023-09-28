
// Recursive Binary Tree

/*           8
          /    \   
         3      10
       /  \      \
      1   6       14
         /  \     / 
        4   7    13 
*/


int[] datas =  { 8 , 3 , 10 , 1 , 6 , 4 ,7 ,10 , 14, 13};

var rootNode = new Node(datas[0]); // rootNode ilk elemanla başlatılır.

foreach (var data in datas.Skip(1)) // Ilk elemanı atlayarak (çünkü o zaten rootNode) diğer elemanları döngüye alırız.
{
    AddNode(rootNode, data);
}

Traverse(rootNode);

var result = isContains(6, rootNode); 

Console.ReadLine();

bool isContains(int value, Node rootNode) 
{
    // Girilen sayının Node içerisinde olup olmadığını kontrol eder.
    if (rootNode == null)
        return false;

    if (value == rootNode.Val)
        return true;

    if (value < rootNode.Val)
        return isContains(value, rootNode.LeftNode);
    
    else
        return isContains(value, rootNode.RightNode);
}

void Traverse(Node rootNode)
{
    if (rootNode == null)
        return;

    Traverse(rootNode.LeftNode);
    Console.WriteLine(rootNode.Val);
    Traverse(rootNode.RightNode);
}

void AddNode(Node rootNode, int val)
{
    if (val < rootNode.Val)
    {
        if (rootNode.LeftNode is null)
        {
            rootNode.LeftNode = new Node(val);
            return;
        }
        else
        {
            AddNode(rootNode.LeftNode, val);
        }
    }
    else
    {
        if (rootNode.RightNode is null)
        {
            rootNode.RightNode = new Node(val);
            return;
        }
        else
        {
            AddNode(rootNode.RightNode, val);
        }
    }
}

class Node
{
    public Node(int val)
    {
        Val = val;
    }
    public int Val { get; set; }

    public Node LeftNode { get; set; }
    public Node RightNode { get; set; }
}



















//Console.WriteLine("Index: {0}",index);
//Console.ReadLine();



