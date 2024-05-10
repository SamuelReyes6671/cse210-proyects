using System;
public class Word{
    private string _text;
    private bool _isHidden;

    public Word(string text){
        _text = text;   
    }
    public void Hide(){
        _isHidden = true;
    }
    public void Shown(){
        _isHidden = false;
    }
    public bool IsHidden(){
        return _isHidden;
    }
    public string GetDisplayText(){ 
        return _text;
    }

}