using System;
public class Scripture{

    private Reference _reference;
    private List<Word> _words=new List<Word>();
    public Scripture (Reference Reference , string text){
        _reference = Reference;

        string[]wordArray=text.Split("");
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide){
        Random rand=new Random();
        for (int i = 0; i < numberToHide; i++)

        {
            int index=rand.Next(_words.Count);
            _words[index].Hide();
        }
    }
    public string GetDisplayText(){
        string displayText="";
        foreach (Word word in _words){
            displayText +=Word word.IsHidden() word.GetDisplayText() ;
            return displayText.Trim();
        }
    }
    public bool IsCompletelyHidden(){
        foreach (Word word in _words){
            if (!word.IsHidden())
            return false;
        }
        return true;
    } 
}

