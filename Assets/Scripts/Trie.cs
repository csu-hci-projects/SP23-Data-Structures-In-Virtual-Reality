// using Scripts;
// public class Trie : MonoBehaviour {
//     public Node root;
//     public Node nodePrefab;

//     void Start() {
//          //make root here 
//     }

//     void Update() {
//         AddWord("Test");
//         // if the button was pressed 
//         // want to add a value to the tree
//     }

//     public void AddWord(String word) {
//         Node newNode = Instantiate(nodePrefab);

//         newNode.transform.setParent(GameObject.find("Root_of_Tree").transform);
//         var currentNode = root;
//         for(int i = 0; i<word.length; i++ ){
//             Node newNode =  Instantiate(nodePrefab);
//             newNode.letter = word[i];
//             if(currentNode.children.contains(newNode)){
//                 currentNode= currentNode.children.get(newNode);
//                 continue;
//             }
//             else {
//                 currentNode.children.add(newNode);
//                 currentNode = currentNode.children.get(newNode);
//             }

//         }
//     }

// }