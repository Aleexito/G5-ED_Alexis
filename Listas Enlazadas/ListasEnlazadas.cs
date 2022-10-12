public class ListasEnlazadas{
    private node head;
    private node tail;
    private string name;

    public createList (string listName) {
        name = listName;
        head = tail = null;
    }

    public bool isListEmpty () {
        if (head == null) {
            return true;
        }
        return false;
    }

    public void insertHeadNode(int data){ 
        node newHead = new node();
        
        if(isListEmpty){
            newHead.newNode(data);
            head = tail = newHead;
        }
        else{
            newHead.setData(data);
            newHead.setNext(head);
            head = newHead;
        }
    }

    public void insertTailNode(int data) {
        node newTail = new node();
        newTail.setData(data);
        if(isListEmpty){
            head = tail = newTail;
        }
        else{
            tail.setNext(newTail);
            tail = newTail;

        }
    }

    public int deleteHead(){
        if(isListEmpty){
            throw new emptyListException(name);
        }
        int deletedNode = head.getData;
        if(head == tail){
            head = tail = null;
        }
        else{
            head = head.getNext;
        }
        return deletedNode;
    }

    public void Print(){
        if(isListEmpty){
            Console.WriteLine("La lista esta vacía");
        }
    }
}