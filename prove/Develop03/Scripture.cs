//Written by Troy
class Scripture
{
    //Attributes
    Reference _reference = new Reference();
    List<Word> _words = new();

    //Methods
    public void Display()
    {
        foreach (Word word in _words)
        {
            word.Display();
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
