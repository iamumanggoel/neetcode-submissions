
public class Node {
    public int key;
    public int value;
    public Node prev;
    public Node next;

    public Node(int key = 0, int value = 0) {
        this.key = key;
        this.value = value;
    }

}

public class LRUCache 
{
    private int capacity;
	private Dictionary<int, Node> map;
	private Node head;
	private Node tail;
	
	public LRUCache(int capacity){
		this.capacity = capacity;
		map = new Dictionary<int, Node>();
		
		head = new Node();
		tail = new Node();
		
		head.next = tail;
		tail.prev = head;
	}
	
	public void Put(int key, int value)
	{
		if(map.ContainsKey(key)){
			Node existingNode = map[key];
			existingNode.value = value;
			Remove(existingNode);
			AddToFront(existingNode);
			map[key] = existingNode;
		}
		else{
			while(map.Count >= capacity){
				Node lru = tail.prev;
				Remove(lru);
				map.Remove(lru.key);
			}
			Node newNode = new Node(key, value);
			AddToFront(newNode);
			map[key] = newNode;
		}
	}
	
	public int Get(int key){
	
		if(!map.ContainsKey(key))
			return -1;
		
		Node node = map[key];
		Remove(node);
		AddToFront(node);
		
		return node.value;
	}
	
	
	private void AddToFront(Node newNode){
		newNode.next = head.next;
		newNode.prev = head;
		newNode.next.prev = newNode;
		head.next = newNode;
		
	}
	
	private void Remove(Node node){
		node.prev.next = node.next;
		node.next.prev = node.prev;
	}
	
}
