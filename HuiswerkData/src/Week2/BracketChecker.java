package Week2;

/**
 * Created by lurtze1 on 15-Sep-16.
 */
public class BracketChecker {

    public boolean checkBrackets(String s) {
        Boolean bool = true;
        MyStack<Character> stack = new MyStack<Character>();
        for(int i = 0; i < s.length(); i++){
            stack.Push(s.charAt(i));
        }
        int brackets = 0;
        char current;
        for(int i = 0; i < stack.getLength(); i++){
            current = stack.Pop();
            if(current == '('){
                brackets++;
            } else if(current == ')'){
                brackets--;
            }

        }
        if(brackets != 0) bool = false;
        return bool;
    }
}
