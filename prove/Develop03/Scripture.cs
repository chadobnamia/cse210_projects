public class Scripture
{
    private  Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, List<string> text)
    {   
        _reference = Reference;
         _words = new List<Word>();
         foreach (string word in text)
         {
            _words.Add(new Word(word));
         }
    }
    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = _words.Where(text => !text.IsHidden()).ToList();

        for(int i = 0; i<Math.Min(numberToHide, visibleWords.Count); i++)
        {
            int index = new Random().Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }
    public string GetDisplayText()
    {
        return string.Join(" ",_words.Select(text => text.GetDisplayText()));
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(text => text.IsHidden());
    }
}