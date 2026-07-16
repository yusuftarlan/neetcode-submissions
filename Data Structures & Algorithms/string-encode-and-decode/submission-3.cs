public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder encoded = new();
        foreach (string str in strs)
        {
            
            encoded.Append(str);
            encoded.Append('\0');
            
        }

        return encoded.ToString();
        
    }

    public List<string> Decode(string s){
        List<string> result = new();
        StringBuilder temp = new();
        foreach(char ch in s)
        {
            if(ch != '\0')
            {
                temp.Append(ch);
            } 
            else
            {
                result.Add(temp.ToString());
                temp.Clear();
            }
        }
        return result;
   }
}
