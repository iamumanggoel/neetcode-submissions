public class Node {
    public Node next;
    public Node prev;
    public int Key;
    public int Value;

    public Node(int key = 0, int value = 0){
        Key = key;
        Value = value;
    }
}

public class LRUCache {
    
    private Dictionary<int, Node> map; // {Key: class<Node> }
    private int Capacity;
    private Node tail;
    private Node head;

    public LRUCache(int capacity) {
        Capacity = capacity;
        head = new Node();
        tail = new Node();

        head.next = tail;
        tail.prev = head;

        map = new Dictionary<int, Node>();
    }
    
    public int Get(int key) {
        if(!map.ContainsKey(key))
            return -1;

        Node node = map[key];

        Remove(node);
        AddToFront(node);

        return node.Value;
        

    }
    
    public void Put(int key, int value) {

        if(map.ContainsKey(key))
        {
            Node existingNode = map[key];
            existingNode.Value = value;

            Remove(existingNode);
            AddToFront(existingNode);

            map[key] = existingNode;

        }
        else{
            while(map.Count >= Capacity){
                Node lruNode = tail.prev;
                Remove(lruNode);
                map.Remove(lruNode.Key);
            }

            Node newNode = new Node(key, value);
            map[key] = newNode;
            AddToFront(newNode);
        }
    }

    private void AddToFront(Node nodeToAdd){
        nodeToAdd.next = head.next;
        nodeToAdd.prev = head;

        nodeToAdd.next.prev = nodeToAdd;
        head.next = nodeToAdd;
    }

    private void Remove(Node nodeToRemove){
        nodeToRemove.prev.next = nodeToRemove.next;
        nodeToRemove.next.prev = nodeToRemove.prev;
    }
}
