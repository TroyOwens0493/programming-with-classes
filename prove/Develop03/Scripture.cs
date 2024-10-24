// Written by Troy and Daniel Loveless
class Scripture
{
    // Attributes
    Reference _reference;
    List<Word> _words = new();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        List<string> textWords = new(text.Split(' '));
        foreach (string word in textWords)
        {
            Word newWord = new(word);
            _words.Add(newWord);
        }
    }

    // Methods
    public void Display()
    {
        foreach (Word word in _words)
        {
            word.Display();
            Console.Write(' ');
        }
    }

    public void HideWords(int numberOfWordsToHide)
    {
        int i = 0;
        Random rnd = new Random();
        do
        {
            Word wordToHide = _words[rnd.Next(_words.Count())];

            if (wordToHide.GetIsHidden())//Pick a new word if the word is already hidden.
            {
                continue;
            }
            else//Hide the word
            {
                wordToHide.Hide();
                i++;//Increment so we stop when the correct num of words are hidden.
            }

        } while (i < numberOfWordsToHide);

    }
}
